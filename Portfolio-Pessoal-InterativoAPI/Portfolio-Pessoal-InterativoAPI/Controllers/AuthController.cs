using Application.DTOs;
using Application.Interfaces.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Pessoal_InterativoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthHandler _authHandler;

        public AuthController(IAuthHandler authHandler)
        {
            _authHandler = authHandler;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginRequest)
        {
            var user = await _authHandler.Login(loginRequest);
            if (user != null)
            {
                return Ok(user);
            }

            return BadRequest("Autenticação Falhou!");
        }
    }
}
