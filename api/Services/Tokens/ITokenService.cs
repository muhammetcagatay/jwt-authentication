using api.Models;
using api.Models.Entities;

namespace api.Services
{
    public interface ITokenService
    {
        Token CreateToken(User user);
        string CreateRefreshToken();
    }
}
