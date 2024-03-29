using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class ArticleVM
    {
        [Key] public Guid Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Content { get; set; }
        public string? ImageURL { get; set; }
        public DateTime Date { get; set; }
        public HashSet<Comment>? Comments { get; set; } = new HashSet<Comment>();
    }
}
