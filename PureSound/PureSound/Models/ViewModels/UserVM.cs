using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureSound.Models.ViewModels
{
    public class UserVM
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Genre))]
        public Guid FavGenreId { get; set; }
        public Genre FavGenre { get; set; }
        public HashSet<FavouriteTracks> FavouriteTracks { get; set; } = new HashSet<FavouriteTracks>();
        public HashSet<FavouriteArtists> FavouriteArtists { get; set; } = new HashSet<FavouriteArtists>();
        public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
