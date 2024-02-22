using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class AddAlbumVM
    {
        [Required] public string Title { get; set; }
        [Required] public int Year { get; set; }
        public Guid ArtistId { get; set; }
        [Required] public HashSet<Song> Songs { get; set; } = new HashSet<Song>();
        [Required] public string ImageURL { get; set; }
    }
}
