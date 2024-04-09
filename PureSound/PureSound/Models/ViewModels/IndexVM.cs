namespace PureSound.Models.ViewModels
{
    public class IndexVM
    {
        public List<ArtistIndexVM> Artists { get; set; } = new List<ArtistIndexVM>();
        public List<TrackIndexVM> Tracks { get; set; } = new List<TrackIndexVM>();
        public List<ArticleVM> Articles { get; set; } = new List<ArticleVM>();
    }
}
