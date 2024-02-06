using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Artist
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Username { get; set; }
        [Required] public int Age { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Album> Albums { get; set; } = new List<Album>();
        public Guid GenreId { get; set; }
        public Genre MainGenre { get; set; }
        [Required]public string ImageURL { get; set; }
    }
}
