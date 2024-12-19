using Domain.Entities;
using Domain.Interface.Repository;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class AuthRepositorty : IAuthRepositorty
    {
        private readonly ApplicationDbContext _context;

        public AuthRepositorty(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> VerifyUser(string userName, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(e => e.UserName == userName && e.Password == password);
            return user;
        }
    }
}
