using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureSound.Data.Entities;

namespace PureSound.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Category> SeedCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id= Guid.Parse("8bca1029-e8ba-4fba-ae63-fc09bf636c93"),
                    Name = "Lifestyle",
                },
                new Category()
                {
                    Id= Guid.Parse("2817198f-8092-4127-901c-75474ec9cdae"),
                    Name = "BREAKING",
                },
                new Category()
                {
                    Id= Guid.Parse("5dd094e7-07eb-4d1b-be10-b6351f554183"),
                    Name = "New production",
                },
                new Category()
                {
                    Id= Guid.Parse("6c9731cc-a682-48a7-bcdf-8133a5aa1423"),
                    Name = "Rising stars",
                }
            };
        }
    }
}
