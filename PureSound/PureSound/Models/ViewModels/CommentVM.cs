using PureSound.Data.Account;
using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.ViewModels
{
    public class CommentVM
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public Guid ArticleID { get; set; }
        public DateTime Date { get; set; }
    }
}
