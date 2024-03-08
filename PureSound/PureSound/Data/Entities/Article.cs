using System.ComponentModel.DataAnnotations;

namespace PureSound.Data.Entities
{
    public class Article
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Content { get; set; }
        public string? ImageURL { get; set; }
        public DateTime Date { get; set; }
        public HashSet<Comment>? Comments { get; set; } = new HashSet<Comment>();
    }
}
