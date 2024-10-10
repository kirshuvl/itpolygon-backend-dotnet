using Common.Data.Models.Users;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthMs.Services;

public class JwtService(
    IConfiguration configuration
    )
{
    public string GenerateToken(UserEntity user)
    {
        SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(configuration["Jwt:SecretKey"]!));
        SigningCredentials creds = new(key, SecurityAlgorithms.HmacSha256);

        IEnumerable<Claim> claims = new[]
         {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim("firstName", user.FirstName),
            new Claim("lastName", user.LastName),
            new Claim("email", user.Email),
        };

        JwtSecurityToken token = new (
            expires: DateTime.UtcNow.AddMinutes(configuration.GetValue<double>(configuration["Jwt:AccessTokenLifeTimeInMinutes"]!)),
            claims: claims,
            signingCredentials: creds
            );
        
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
