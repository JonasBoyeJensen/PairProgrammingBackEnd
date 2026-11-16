using Microsoft.AspNetCore.Mvc;
using PairProgrammingBackEnd;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordControllers.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;
    private IAuthenticator _authenticator;

    public AuthController(IConfiguration config, IAuthenticator authenticator)
    {
        _config = config;
        _authenticator = authenticator;
    }

    // POST api/<AuthController>
    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public IActionResult Post([FromBody] LoginRequest request)
    {
        Role? role = _authenticator.Authenticate(request.Username, request.Password);
        if (role == null)
        {
            return Unauthorized();
        }

        var token = GenerateJWTToken(request.Username, role.Value);
        return Ok(new { Token = token, Username = request.Username });
    }

    private string GenerateJWTToken(string username, Role role)
    {
        var jwtSettings = _config.GetSection("Jwt");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        // Create claims for the token
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Name, username),
            new Claim(ClaimTypes.Role, role.ToString())
        };
    
        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}

public class LoginRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
