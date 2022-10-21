using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
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
        public IActionResult GetGames()
        {
            try
            {
                var games = _serviceManager.GamesService.GetAllGames(trackChanges: false);
                return Ok(games);
            }

            catch
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        [Route("genre")]
        public IActionResult GetGenre()
        {
            try
            {
                var allGenre = _serviceManager.GenreService.GetAllGenres(trackChanges: false);
                return Ok(allGenre);
            }
            catch
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        [Route("console")]
        public IActionResult GetAllConsole()
        {
            try
            {
                var allConsole = _serviceManager.ConsoleDeviceService.GetAllDevice(trackChanges: false);
                return Ok(allConsole);
            }
            catch
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

    }
}
