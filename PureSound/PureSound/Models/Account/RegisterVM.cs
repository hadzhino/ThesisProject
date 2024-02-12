using PureSound.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PureSound.Models.Account
{
    public class RegisterVM
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Username { get; set; } = null!;
        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
        [Required]
        public Guid GenreId { get; set; }
    }
}
