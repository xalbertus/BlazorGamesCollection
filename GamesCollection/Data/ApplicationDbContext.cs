using Microsoft.EntityFrameworkCore;

namespace GamesCollection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Game> Game { get; set; } = default!;
    }
}
