
using Domain.Entities;

namespace Domain.Interface.Repository
{
    public interface IAuthRepositorty
    {
        Task<User> VerifyUser(string userName, string password);
    }
}
