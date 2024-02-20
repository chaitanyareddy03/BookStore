using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
