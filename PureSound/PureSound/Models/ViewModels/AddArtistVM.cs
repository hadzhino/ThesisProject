using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class AddArtistVM
    {
        [Required] public string Username { get; set; }
        [Required] public int Age { get; set; }
        public Guid GenreId { get; set; }
        public string? ImageURL { get; set; }
        public Guid RegionId { get; set; }
    }
}
