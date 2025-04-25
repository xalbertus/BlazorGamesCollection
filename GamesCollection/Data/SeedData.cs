using GamesCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesCollection.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>());

            if (context == null || context.Game == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppGamesContext or Game DbSet");
            }

            if (context.Game.Any())
            {
                return;
            }

            context.Game.AddRange(
                new Game
                {
                    Title = "God of War",
                    Platform = "PlayStation 2"
                },
                new Game
                {
                    Title = "God of War II",
                    Platform = "PlayStation 2"
                },
                new Game
                {
                    Title = "God of War III",
                    Platform = "PlayStation 3"
                },
                new Game
                {
                    Title = "God of War: Ascension",
                    Platform = "PlayStation 3"
                },
                new Game
                {
                    Title = "God of War: Ragnarok",
                    Platform = "PlayStation 4"
                });

            context.SaveChanges();
        }
    }
}
