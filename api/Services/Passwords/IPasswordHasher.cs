using api.Models;
using Microsoft.AspNetCore.Identity;

namespace api.Services.Passwords
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);

        bool VerifyPassword(string actualPassword, string hashedPassword);
    }
}
