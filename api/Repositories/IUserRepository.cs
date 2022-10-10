using api.Models.Entities;
using System.Threading.Tasks;

namespace api.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByRefreshTokenAsync(string refreshToken);
        Task CommitAsync();
    }
}
