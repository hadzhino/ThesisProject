using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Artist
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Username { get; set; }
        [Required] public int Age { get; set; }
        public HashSet<ArtistTrack>? ArtistTrack { get; set; } = new HashSet<ArtistTrack>();
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public string? ImageURL { get; set; }
        public Guid RegionId { get; set; }
        public Region Region { get; set; }
        public HashSet<FavouriteArtists> FavoriteArtists { get;set; } = new HashSet<FavouriteArtists>();
    }
}
