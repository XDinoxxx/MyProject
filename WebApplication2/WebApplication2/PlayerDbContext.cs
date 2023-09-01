using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }
        public DbSet<Player> Players { get; set; } = null;
    }
}
