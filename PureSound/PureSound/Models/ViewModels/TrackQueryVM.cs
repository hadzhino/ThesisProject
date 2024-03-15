namespace PureSound.Models.ViewModels
{
    public class TrackQueryVM
    {
        public string? SearchString { get; set; }
        public List<TrackVM> Tracks { get; set; } = new List<TrackVM>();
    }
}
