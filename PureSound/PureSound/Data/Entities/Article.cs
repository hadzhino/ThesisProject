using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Article
    {
        [Key]public Guid Id { get; set; }
        [Required]public string Title { get; set; }
        [Required]public string Content { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
