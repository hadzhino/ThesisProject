using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PureSound.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(SeedRoles());
        }
        private List<IdentityRole> SeedRoles()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "91dba846-9346-4180-926b-822a512114a8",
                    Name = "Administrator",
                    NormalizedName= "ADMINISTRATOR",
                },
                new IdentityRole()
                {
                    Id = "59becd7f-9fa3-4daf-99f6-f52f5568dcc6",
                    Name = "User",
                    NormalizedName= "USER",
                }
            };
        }
    }
}
