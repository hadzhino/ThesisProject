using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class AddTrackVM
    {
        [Required][StringLength(maximumLength: 50)] public string Title { get; set; }
        public HashSet<Artist> Artists { get; set; } = new HashSet<Artist>();
        public string Lyrics { get; set; }
        [Required] public int Year { get; set; }
        public Guid GenreId { get; set; }
        public Guid AlbumId { get; set; }
        [Required] public string ImageURL { get; set; }
    }
}
