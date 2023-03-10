using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Models
{
    public class MovieEntry
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes limited to 25 characters.")]
        public string Notes { get; set; }
    }
}
