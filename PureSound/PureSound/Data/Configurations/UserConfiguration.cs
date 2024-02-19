using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureSound.Data.Account;

namespace PureSound.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "etaleksander411@gmail.com",
                NormalizedEmail = "ETALEKSANDER411@GMAIL.COM",
                FavGenreId = Guid.Parse("48d67181-5732-47a0-892b-6577fc688e00")
            };
            user.PasswordHash = hasher.HashPassword(user, "@Aleks005");

            users.Add(user);

            return users;
        }
    }
}
