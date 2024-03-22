using Microsoft.AspNetCore.Identity;
using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureSound.Data.Account
{
    public class User : IdentityUser
    {
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Genre))]
        public Guid FavGenreId { get; set; }
        public Genre FavGenre { get; set; }
        public HashSet<FavouriteTracks> FavouriteTracks { get; set; } = new HashSet<FavouriteTracks>();
        public HashSet<FavouriteArtists> FavouriteArtists { get; set; } = new HashSet<FavouriteArtists>();
        public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
