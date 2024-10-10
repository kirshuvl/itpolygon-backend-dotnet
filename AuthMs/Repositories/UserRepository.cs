using Common;
using Common.Data.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace AuthMs.Repositories;

public class UserRepository(ApplicationDbContext applicationContext)
{
    public async Task<UserEntity> CreateUserAsync(UserEntity user)
    {
        applicationContext.Add(user);
        await applicationContext.SaveChangesAsync();

        return user;
    }

    public async Task<UserEntity> GetUserByEmailAsync(string email)
    {
        UserEntity user = await applicationContext.Users
            .FirstAsync(_ => _.Email == email);

        return user;
    }
}

