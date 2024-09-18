using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.Models.UserModels;

namespace MultipleContext.Data.Contexts;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions options) : base(options)
    {
    }
}
