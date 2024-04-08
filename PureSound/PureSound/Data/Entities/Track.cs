using Microsoft.EntityFrameworkCore;
using PureSound.Data.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureSound.Data.Entities
{
    public class Track
    {
        [Key] public Guid Id { get; set; }
        [StringLength(maximumLength: 50)] public string? Title { get; set; }
        public HashSet<ArtistTrack>? ArtistTrack { get; set; } = new HashSet<ArtistTrack>();
        public string? Lyrics { get; set; }
        [Required] public int Year { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
        public string YouTubeURL { get; set; }
        public HashSet<FavouriteTracks> FavoriteTracks { get; set; } = new HashSet<FavouriteTracks>();
        public int FavouriteCount { get; set; }
    }
}
