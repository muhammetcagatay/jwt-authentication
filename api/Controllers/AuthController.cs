using api.Data;
using api.Models;
using api.Models.Dtos;
using api.Models.Entities;
using api.Repositories;
using api.Services;
using api.Services.Passwords;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHasher _passwordHasher;
        public AuthController(ITokenService tokenService, IPasswordHasher passwordHasher, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher; 
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            User user = await _userRepository.GetByEmailAsync(userLogin.Email);

            if (user == null)
            {
                return BadRequest(new { message = "No registered user for this email." });
            }

            var passwordValid = _passwordHasher.VerifyPassword(userLogin.Password, user.Password);

            if (!passwordValid)
            {
                return BadRequest(new { message = "İnvalid password" });
            }

            Token token = _tokenService.CreateToken(user);

            user.RefreshToken = token.RefreshToken;
            user.RefreshTokenEndDate = token.Expiration.AddMinutes(5);
            await _userRepository.CommitAsync();

            return Ok(token);
        }
        [HttpPost("refreshToken")]
        public async Task<IActionResult> Login(RefreshToken refreshToken)
        {
            User user = await _userRepository.GetByRefreshTokenAsync(refreshToken.Token);

            if (user == null)
            {
                return BadRequest(new { message = "refresh token is invalid." });
            }
            if(user.RefreshTokenEndDate < DateTime.Now)
            {
                return BadRequest(new { message = "refresh token expired" });
            }


            Token token = _tokenService.CreateToken(user);

            user.RefreshToken = token.RefreshToken;
            user.RefreshTokenEndDate = token.Expiration.AddMinutes(5);
            await _userRepository.CommitAsync();

            return Ok(token);
        }
    }
}
