using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class AddTrackVM
    {
        public string Title { get; set; }
        public HashSet<ArtistsSong>? ArtistsSong { get; set; } = new HashSet<ArtistsSong>();
        public HashSet<Guid>? ArtistsIds { get; set; } = new HashSet<Guid>();
        public string? Lyrics { get; set; }
        public int Year { get; set; }
        public Guid GenreId { get; set; }
        public string? ImageURL { get; set; }
        public string YouTubeURL { get; set; }
    }
}
