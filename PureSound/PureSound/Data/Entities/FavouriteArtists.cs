using PureSound.Data.Account;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class FavouriteArtists
    {
        [Key] public Guid Id { get; set; }
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
