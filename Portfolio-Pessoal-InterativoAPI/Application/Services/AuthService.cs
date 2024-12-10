using Application.DTOs;
using Application.Interfaces.Services;
using Domain.Interface.Repository;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepositorty _authRepository;

        public AuthService(IAuthRepositorty authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<TokenDTO> Login(LoginDTO loginRequest)
        {
            var user = await _authRepository.VerifyUser(loginRequest.UserName, loginRequest.Password);

            if (user != null)
            {
                var token = GenerateToken
            }
        }
    }
}
