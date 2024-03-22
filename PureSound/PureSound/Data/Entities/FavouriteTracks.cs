using PureSound.Data.Account;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class FavouriteTracks
    {
        [Key] public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid TrackId { get; set; }
        public Track Track { get; set; }
    }
}
