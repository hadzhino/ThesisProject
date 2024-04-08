using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class ArticleVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string? ImageURL { get; set; }
        public DateTime Date { get; set; }
        public HashSet<Comment>? Comments { get; set; } = new HashSet<Comment>();
        public CommentVM Comment { get; set; }
    }
}
