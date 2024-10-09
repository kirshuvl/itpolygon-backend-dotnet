using Common.Data.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Common;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public required DbSet<UserEntity> Users { get; set; }
}
