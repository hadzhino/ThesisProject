using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Genre
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}
