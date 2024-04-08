using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class TrackVM
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public HashSet<ArtistTrack> ArtistTrack { get; set; } = new HashSet<ArtistTrack>();
        public string? Lyrics { get; set; }
        public int Year { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
        public string YouTubeURL { get; set; }
        public bool IsLikedByCurrentUser { get; set; } = false;
        public HashSet<FavouriteTracks> FavoriteTracks { get; set;} = new HashSet<FavouriteTracks>();
        public int FavouriteCount { get; set; }

    }
}
