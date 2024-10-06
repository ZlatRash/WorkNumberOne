using Microsoft.EntityFrameworkCore;
using WorkNumberOne.Models.data.user;

namespace WorkNumberOne.Models.data.context;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }
}