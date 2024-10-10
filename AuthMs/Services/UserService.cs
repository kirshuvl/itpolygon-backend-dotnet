using AuthMs.Repositories;
using Common.Data.Models.Users;

namespace AuthMs.Services;

public class UserService(
    UserRepository userRepository
    )
{
    public async Task<UserEntity> Register(string FirstName, string LastName, string Email, string Password)
    {
        UserEntity user = new()
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            PasswordHash = Password

        };

        UserEntity createdUser = await userRepository.CreateUserAsync(user);

        return createdUser;
    }

    public async Task<UserEntity> Login(string Email, string Password)
    {
        UserEntity user = await userRepository.GetUserByEmailAsync(Email);

        return user;
    }
}
