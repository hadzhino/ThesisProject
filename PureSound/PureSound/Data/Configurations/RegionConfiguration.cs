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
                    Id = Guid.Parse("ae75b350-c7bf-4989-8494-37d4520bca9d"),
                    Name = "West Coast (NORTH AMERICA)"
                },
                new Region
                {
                    Id = Guid.Parse("7ca6dda2-0349-4643-985f-4da6b0005e05"),
                    Name = "East Coast (NORTH AMERICA)"
                },
                new Region
                {
                    Id = Guid.Parse("952056b4-8c59-4cfb-880e-b5596bbca980"),
                    Name = "South America"
                },
                new Region
                {
                    Id = Guid.Parse("efc55abf-0af6-49ab-85bb-b4f4dbb88b77"),
                    Name = "Latin America"
                },
                new Region
                {
                    Id = Guid.Parse("d9ec6219-54bd-436c-babc-be85309028a8"),
                    Name = "Africa"
                },
                new Region
                {
                    Id= Guid.Parse("5dea7b8a-3e0e-49d5-8017-f1cd7200822e"),
                    Name = "Middle East (ASIA)"
                },
                new Region
                {
                    Id = Guid.Parse("1361b02b-40eb-4728-9ca2-8efc1f815ae9"),
                    Name = "West Europe"
                },
                new Region
                {
                    Id = Guid.Parse("169452fc-57f0-4f8b-896d-844ce50913e3"),
                    Name = "East Europe"
                },
                new Region
                {
                    Id = Guid.Parse("d5510f72-ae7c-4ced-9d1d-bb9f34c49a44"),
                    Name = "Balkans (EUROPE)"
                },
                new Region
                {
                    Id = Guid.Parse("b4790f50-6fea-4149-8766-704f3c97e5d5"),
                    Name = "Oceania"
                },
                new Region
                {
                    Id = Guid.Parse("f4d9d24d-a82c-4177-8626-7f1cf75373cb"),
                    Name = "East Asia"
                },
                new Region
                {
                    Id = Guid.Parse("818445d8-9ecd-48ec-ad36-c6ba0b81673a"),
                    Name = "Middle Asia"
                },
                new Region
                {
                    Id = Guid.Parse("b4cda450-e949-4c90-ab64-11b64efdb648"),
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
