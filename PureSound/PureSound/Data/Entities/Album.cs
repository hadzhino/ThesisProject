using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Album
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public int Year { get; set; }
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }
        [Required] public HashSet<Song> Songs { get; set; } = new HashSet<Song>();
        [Required]public string ImageURL { get; set; }
    }
}
