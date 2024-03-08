using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class ArtistVM
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public HashSet<ArtistsSong>? ArtistsSongs { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
    }
}
