using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Artist
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Username { get; set; }
        [Required] public int Age { get; set; }
        public HashSet<ArtistsSong>? ArtistSongs { get; set; } = new HashSet<ArtistsSong>();
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
    }
}
