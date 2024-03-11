using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class TrackVM
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public HashSet<ArtistsSong> ArtistSongs { get; set; } = new HashSet<ArtistsSong>();
        public string? Lyrics { get; set; }
        public int Year { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
        public string YouTubeURL { get; set; }
    }
}
