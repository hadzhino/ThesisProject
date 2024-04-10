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
                    Id = Guid.Parse("1bd404c8-383c-4ac0-b5c4-5f966378ba6e"),
                    Name = "Trap"
                },
                new Genre
                {
                    Id = Guid.Parse("b1b61127-eb68-42d4-b80c-494da4d975fe"),
                    Name = "Rap"
                },
                new Genre
                {
                    Id = Guid.Parse("dc5a739c-1137-4950-9225-57d0c13ed662"),
                    Name = "Pop"
                },
                new Genre
                {
                    Id = Guid.Parse("f62b7c2d-1cc7-4715-88c5-79c901affbc0"),
                    Name = "Drill"
                },
                new Genre
                {
                    Id = Guid.Parse("45a0a748-b70f-4599-bf16-38d76847cc77"),
                    Name = "Raeggeton"
                },
                new Genre
                {
                    Id = Guid.Parse("7fb34588-41f0-4871-9fa9-523c03c93698"),
                    Name = "House"
                },
                new Genre
                {
                    Id = Guid.Parse("046d8ace-f895-4aa5-8c99-6e69433ccef7"),
                    Name = "R&B"
                },
                new Genre
                {
                    Id = Guid.Parse("302e4c3d-c953-4baa-b645-242b364ce648"),
                    Name = "Techno"
                },
                new Genre
                {
                    Id = Guid.Parse("797fe793-914a-42a6-8207-c0a82d4a539c"),
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
