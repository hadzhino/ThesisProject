using PureSound.Data.Account;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Genre
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public HashSet<Track> Tracks { get; set; } = new HashSet<Track>();
        public HashSet<Artist> Artists { get; set; } = new HashSet<Artist>();
        public HashSet<User> Users { get; set; } = new HashSet<User>();
    }
}
