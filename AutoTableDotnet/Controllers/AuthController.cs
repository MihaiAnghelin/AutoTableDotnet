using AutoTableDotnet.DTOs;
using AutoTableDotnet.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController, Route("api/auth")]
public class AuthController : Controller
{
    private readonly ITokenEmitterService _tokenEmitterService;

    public AuthController(ITokenEmitterService tokenEmitterService)
    {
        _tokenEmitterService = tokenEmitterService;
    }

    [HttpPost("login")]
    public async Task<ServiceResultDTO> Login([FromBody] LoginDTO loginDTO)
    {
        var result = new ServiceResultDTO()
        {
            StatusCode = StatusCodes.Status200OK
        };

        if (loginDTO.Username != "admin" || loginDTO.Password != "br8RbUvK")
        {
            result.StatusCode = StatusCodes.Status401Unauthorized;
            result.Error = "Invalid username or password";
            return result;
        }

        result.Data = new
        {
            Token = _tokenEmitterService.GenerateAuthToken("adminUser"),
        };

        return result;
    }
}