namespace PureSound.Models.ViewModels
{
    public class IndexVM
    {
        public List<ArtistVM> Artists { get; set; } = new List<ArtistVM>();
        public List<TrackVM> Tracks { get; set; } = new List<TrackVM>();
        public List<ArticleVM> Articles { get; set; } = new List<ArticleVM>();
    }
}
