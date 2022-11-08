using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public ActionResult GetGames()
        {
            var games = _serviceManager.GamesService.GetAllGames(false);
            return Ok(games);
            
        }

        [HttpGet]
        [Route("genre")]
        public IActionResult GetGenre()
        {
            var allGenre = _serviceManager.GenreService.GetAllGenres(false);
            return Ok(allGenre);
        }

        [HttpGet]
        [Route("console")]
        public IActionResult GetAllConsole()
        {
            var allConsole = _serviceManager.ConsoleDeviceService.GetAllDevice(false);
            return Ok(allConsole);
        }

        [HttpGet]
        [Route("{id:int}", Name ="GameById")]
        public IActionResult GetGameById([FromRoute] int id)
        {
            var game = _serviceManager.GamesService.GetGameById(id, false);
            return Ok(game);
        }

        [HttpPost]
        public IActionResult CreateGame([FromBody] GameForCreateDto games)
        {
            if (games == null) return BadRequest("GamesForCreateDto is null");

            var game = _serviceManager.GamesService.CreateGame(games);
            return CreatedAtRoute("GameById", new { id = game.id }, game);
        }

    }
}
