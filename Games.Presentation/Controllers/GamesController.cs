using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GamesPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public GamesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetGames([FromQuery] GameParameters gameParameters)
        {
            var pagedResult = await _serviceManager.GamesService.GetAllGames(false, gameParameters);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.games);
            
        }

        [HttpGet]
        [Route("genre")]
        public async Task<IActionResult> GetGenre()
        {
            var allGenre = await _serviceManager.GenreService.GetAllGenres(false);
            return Ok(allGenre);
        }

        [HttpGet]
        [Route("console")]
        public async Task<IActionResult> GetAllConsole()
        {
            var allConsole = await _serviceManager.ConsoleDeviceService.GetAllDevice(false);
            return Ok(allConsole);
        }

        [HttpGet]
        [Route("{id:int}", Name ="GameById")]
        public async Task<IActionResult> GetGameById([FromRoute] int id)
        {
            var game = await _serviceManager.GamesService.GetGameById(id, false);
            return Ok(game);
        }


        [HttpPost]
        public async Task<IActionResult> CreateGame([FromBody] GameForCreateDto games)
        {
            if (games is null) return BadRequest("GamesForCreateDto is null");

            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);
            

            var game = await _serviceManager.GamesService.CreateGame(games);
            return CreatedAtRoute("GameById", new { id = game.id }, game);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteGame(int id, bool trackChanges)
        {
            await _serviceManager.GamesService.DeleteGame(id, false);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateGame(int id, GameForUpdateDto  gamesForUpdateDto,bool trackChanges)
        {
            if (gamesForUpdateDto is null) return BadRequest("gamesForUpdateDto is null");

            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);

            _serviceManager.GamesService.UpdateGame(id, gamesForUpdateDto, true);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> PartiallyUpdateEmployeeForCompany(int id, [FromBody] JsonPatchDocument<GameForUpdateDto> gamePatch)
        {
            if (gamePatch == null) return BadRequest("gamePatch sent from client is null");

            var result = await _serviceManager.GamesService.GetGameForPatch(id, true);

            gamePatch.ApplyTo(result.gameToPatch, ModelState);

            TryValidateModel(result.gameToPatch);

            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);

            await _serviceManager.GamesService.SaveChangesForPatch(result.gameToPatch, result.gameEntity);

            return NoContent();
        }

    }
}
