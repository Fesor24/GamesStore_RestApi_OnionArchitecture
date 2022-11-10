using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController: ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AccountController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpPost("register")]
        public async Task<IActionResult> CreateUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _serviceManager.AccountService.RegisterUser(userForRegistration);

            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForLoginDto userForLogin)
        {
            if (!await _serviceManager.AccountService.ValidateUser(userForLogin))
                return Unauthorized();

            return Ok(new { Token = await _serviceManager.AccountService.CreateToken() });
        }
        




    }
}
