using PureSound.Data.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PureSound.Data.Entities
{
    public class Comment
    {
        [Key] public Guid Id { get; set; }
        [ForeignKey(nameof(User))]public string UserId { get; set; }
        public User User { get; set; }
        public string? Content { get; set; }
        [ForeignKey(nameof(Article))]public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public DateTime Date = DateTime.Now;
    }
}
