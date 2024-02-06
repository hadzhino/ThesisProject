using Microsoft.AspNetCore.Identity;
using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Account
{
    public class User : IdentityUser
    {
        public string ImageURL { get; set; }
        public Guid GenreId { get; set; }
        public Genre FavGenre { get; set; }
        public List<Song> FavSongs { get; set; } = new List<Song>();
        public List<Artist> FavArtists { get; set; } = new List<Artist>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
