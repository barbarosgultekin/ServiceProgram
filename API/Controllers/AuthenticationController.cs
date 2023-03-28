using Business.Abstract;
using Core.Plugins.Authentication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;
        public AuthenticationController(IAuthenticationService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestModel loginModel)
        {
            var userToLogin = await _service.LoginAsync(loginModel);
            if (userToLogin == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestModel registerModel)
        {
            var userToRegister = await _service.RegisterAsync(registerModel, registerModel.Password);
            if (userToRegister == null)
            {
                return BadRequest();
            }
            return Ok();
        }       

    }
}
