using AccountService.Model;
using AccountService.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AccountService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        static readonly User[] users = new User[]
        {
            new User()
            {
                Password= "1234",
                Username="dilshod",
                Role="admin"
            }
        };

        const string appSettingsToken = "MyKeaskJKASJDKJASDUKKJSA781273,44$";

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            var user = users.FirstOrDefault(s => s.Username == loginRequest.Username && s.Password == loginRequest.Password);
            if (user != null)
            {
                List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email,loginRequest.Username),
                new Claim(JwtRegisteredClaimNames.Iss,"MyApp"),
                new Claim(ClaimTypes.Role,user.Role),
                new Claim(JwtRegisteredClaimNames.Aud,"MyAppClients")
            };

                SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                  .GetBytes(appSettingsToken));

                SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    SigningCredentials = creds
                };

                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
                return Ok(tokenHandler.WriteToken(token));
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}