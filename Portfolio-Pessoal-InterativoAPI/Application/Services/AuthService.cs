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
    }
}
