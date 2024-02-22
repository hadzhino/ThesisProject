using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class AddArtistVM
    {
        [Required] public string Username { get; set; }
        [Required] public int Age { get; set; }
        public HashSet<Song> Songs { get; set; } = new HashSet<Song>();
        public HashSet<Album> Albums { get; set; } = new HashSet<Album>();
        public Guid GenreId { get; set; }
        [Required] public string ImageURL { get; set; }
    }
}
