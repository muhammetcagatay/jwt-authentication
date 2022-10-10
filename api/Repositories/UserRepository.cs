using api.Data;
using api.Models.Entities;
using api.Services.Passwords;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher _passwordHasher;
        public UserRepository(ApplicationDbContext context, IPasswordHasher passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;

            _context.Database.Migrate();

            if (!_context.User.Any())
            {


                var user = new User { Email = "admin@gmail.com", Password = _passwordHasher.HashPassword("123456") };

                _context.Add(user);

                _context.SaveChanges();
            } 
        }
        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _context.User.FirstOrDefaultAsync(x => x.Email == email);

            return user;
        }
        public async Task<User> GetByRefreshTokenAsync(string refreshToken)
        {
            var user = await _context.User.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);

            return user;

        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
