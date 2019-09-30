using System.ComponentModel.DataAnnotations;

namespace Restaurants.Core
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; }

    }
}
