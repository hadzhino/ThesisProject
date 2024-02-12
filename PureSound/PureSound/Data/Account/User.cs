using Microsoft.AspNetCore.Identity;
using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureSound.Data.Account
{
    public class User : IdentityUser
    {
        [ForeignKey(nameof(Genre))]
        public Guid GenreId { get; set; }
        public Genre FavGenre { get; set; }
        public HashSet<Song> FavSongs { get; set; } = new HashSet<Song>();
        public HashSet<Artist> FavArtists { get; set; } = new HashSet<Artist>();
        public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
