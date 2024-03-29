using Microsoft.Identity.Client;
using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class ArtistVM
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public HashSet<ArtistTrack>? ArtistTrack { get; set; } = new HashSet<ArtistTrack>();
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
        public Guid RegionId { get; set; }
        public Region Region { get; set; }
        public bool IsLikedByCurrentUser { get; set; }
        public HashSet<FavouriteArtists>? FavoriteArtists { get;set; } = new HashSet<FavouriteArtists>();
    }
}
