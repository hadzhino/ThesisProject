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
                    Id= Guid.NewGuid(),
                    Name = "Lifestyle",
                    ArticleCategory = null!
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    Name = "BREAKING",
                    ArticleCategory = null!
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    Name = "New production",
                    ArticleCategory = null!
                },
                new Category()
                {
                    Id= Guid.NewGuid(),
                    Name = "Rising stars",
                    ArticleCategory = null!
                },
            };
        }
    }
}
