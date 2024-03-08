using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class DeleteTrackVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public HashSet<ArtistsSong> ArtistsSong { get; set; } = new HashSet<ArtistsSong>();
        public HashSet<string> ArtistsNames { get; set; } = new HashSet<string>();
        public string? Lyrics { get; set; }
        public int Year { get; set; }
        public Guid GenreId { get; set; }
        public string? ImageURL { get; set; }
    }
}
