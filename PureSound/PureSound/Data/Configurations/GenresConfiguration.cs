using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureSound.Data.Entities;

namespace PureSound.Data.Configurations
{
    public class GenresConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(SeedGenres());
        }

        private List<Genre> SeedGenres()
        {
            return new List<Genre>()
            {
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Rap"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Drill"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Raeggeton"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "House"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "R&B"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Techno"
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    Name = "Phonk"
                },
                new Genre
                {
                    Id = Guid.Parse("48d67181-5732-47a0-892b-6577fc688e00"),
                    Name = "None"
                }
            };
        }
    }
}
