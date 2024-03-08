using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class ArtistsSong
    {
        [Key]public Guid Id { get; set; }
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }
        public Guid SongId { get; set; }
        public Song Song { get; set; }
    }
}
