using Application.DTOs;

namespace Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<TokenDTO> Login(LoginDTO loginRequest);
    }
}
