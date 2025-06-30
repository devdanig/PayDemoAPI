using Microsoft.EntityFrameworkCore;
using PayDemoAPI.Models;

namespace PayDemoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Account> Accounts => Set<Account>();
    }
}