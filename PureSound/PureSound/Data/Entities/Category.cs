namespace PureSound.Data.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<ArticleCategory> ArticleCategory { get; set; } = new HashSet<ArticleCategory>();
    }
}
