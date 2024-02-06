using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Song
    {
        [Key] public Guid Id { get; set; }
        [Required][StringLength(maximumLength: 50)] public string Title { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public string Lyrics { get; set; }
        [Required] public int Year { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        [Required] public string ImageURL { get; set; }
    }
}
