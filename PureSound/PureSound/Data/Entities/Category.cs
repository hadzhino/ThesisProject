namespace PureSound.Data.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<Article> Articles { get; set; }
    }
}
