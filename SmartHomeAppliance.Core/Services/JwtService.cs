using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SmartHomeAppliance.Core.Contracts;
using SmartHomeAppliance.Infrastructure.Data.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static SmartHomeAppliance.Common.CustomErrors.GlobalErrors;

namespace SmartHomeAppliance.Core.Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration config;
        private readonly UserManager<ApplicationUser> userManager;

        public JwtService(IConfiguration config, UserManager<ApplicationUser> userManager)
        {
            this.config = config;
            this.userManager = userManager;
        }
        public async Task<string> GenerateTokenAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
                throw new ArgumentException(UserNotFound);
           
            var userRoles = await userManager.GetRolesAsync(user);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: config["Jwt:Issuer"],
                audience: config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(double.Parse(config["Jwt:ExpiryMinutes"]!)),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
