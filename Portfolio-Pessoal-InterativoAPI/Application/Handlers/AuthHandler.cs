using Application.DTOs;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;

namespace Application.Handlers
{
    public class AuthHandler : IAuthHandler
    {
        private readonly IAuthService _authService;

        public AuthHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public Task<TokenDTO> Login(LoginDTO loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
