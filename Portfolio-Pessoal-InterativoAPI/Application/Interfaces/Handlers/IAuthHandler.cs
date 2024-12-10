using Application.DTOs;

namespace Application.Interfaces.Handlers
{
    public interface IAuthHandler
    {
        Task<TokenDTO> Login(LoginDTO loginRequest);
    }
}
