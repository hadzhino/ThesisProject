using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureSound.Data.Entities;

namespace PureSound.Data.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(SeedRegions());
        }

        private List<Region> SeedRegions() 
        {
            return new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "West Coast (NORTH AMERICA)"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "East Coast (NORTH AMERICA)"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "South America"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Latin America"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Africa"
                },
                new Region
                {
                    Id= Guid.NewGuid(),
                    Name = "Middle East (ASIA)"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "West Europe"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "East Europe"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Balkans (EUROPE)"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Oceania"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "East Asia"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Middle Asia"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "West Asia"
                },
                new Region
                {
                    Id = Guid.Parse("d07cd5fe-c2e6-46a7-87a0-2d427ea9d05a"),
                    Name = "None"
                }
            };
        }
    }
}
