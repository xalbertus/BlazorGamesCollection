using System.ComponentModel.DataAnnotations;

namespace GamesCollection.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 1)]
        public string? Title { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        public string? Platform { get; set; }
    }
}
