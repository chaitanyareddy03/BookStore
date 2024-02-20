using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string GenreName { get; set; }
    }
}
