using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class ArticleCategory
    {
        [Key]public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public Guid CategoryId { get; set; }
        public Article Article { get; set; }
        public Category Category { get; set; }
    }
}
