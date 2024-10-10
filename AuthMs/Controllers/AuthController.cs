
using AuthMs.Services;
using Common;
using Common.Data.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AuthMs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(
    UserService userService,
    JwtService jwtService
)
{

    [HttpPost]
    public async Task<Ok<UserRegisterResponse>> Register([FromBody] UserRegisterRequest userRequest)
    {
        UserEntity user = await userService.Register(
                FirstName: userRequest.FirstName,
                LastName: userRequest.LastName,
                Email: userRequest.Email,
                Password: userRequest.Password
                );

        return TypedResults.Ok(new UserRegisterResponse
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        });
    }

    [HttpPost]
    [Route("/token")]
    public async Task<Ok<string>> Login([FromBody] UserLoginRequest userRequest)
    {
        UserEntity user = await userService.Login(
                Email: userRequest.Email,
                Password: userRequest.Password
                );

        string token = jwtService.GenerateToken(user);

        Debug.WriteLine(token);
        return TypedResults.Ok(token);


    }

    [HttpGet]
    [Route("/test")]
    [Authorize]
    public async Task<Ok<string>> Test()
    {
        return TypedResults.Ok("asd");
    }
}
