using Microsoft.EntityFrameworkCore;

namespace InstantScratchIts.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<InstantGame> InstantGames { get; set; }
    }
}