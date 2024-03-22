namespace PureSound.Data.Entities
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<Artist> Artists { get; set; }
    }
}
