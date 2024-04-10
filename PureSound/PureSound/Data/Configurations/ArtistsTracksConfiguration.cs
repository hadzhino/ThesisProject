using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PureSound.Data.Entities;

namespace PureSound.Data.Configurations
{
    public class ArtistsTracksConfiguration : IEntityTypeConfiguration<ArtistTrack>
    {
        public void Configure(EntityTypeBuilder<ArtistTrack> builder)
        {
            builder.HasData(SeedGenres());
        }

        private List<ArtistTrack> SeedGenres()
        {
            return new List<ArtistTrack>()
            {
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("231ff15f-d918-4aa4-8eb7-ad056f6130af"),
                    TrackId = Guid.Parse("788944dc-fe8a-4c72-95a0-f2e7242a8a24"),
                },
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("e6bed5b4-70e9-48d4-b887-5c8339e088bd"),
                    TrackId = Guid.Parse("2f725c58-72d6-4201-848c-b3cb521dfa9d"),
                },
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("fccdb498-2db4-4d0a-a7ee-85b61398a2cb"),
                    TrackId = Guid.Parse("2f725c58-72d6-4201-848c-b3cb521dfa9d"),
                },
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("1189c2f4-96b9-41fa-aead-2de6e8f2b4b5"),
                    TrackId = Guid.Parse("ebf7c421-7148-4f78-9c53-1600572c441f"),
                },
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("3032d205-1ade-4e21-91f7-d15845cbeff5"),
                    TrackId = Guid.Parse("29edf751-e100-41b2-97eb-c517b0ba806f"),
                },
                new ArtistTrack
                {
                    Id = Guid.NewGuid(),
                    ArtistId = Guid.Parse("1e0677d5-29af-4ba5-b535-312c2b377d46"),
                    TrackId = Guid.Parse("140931b6-1b86-4203-92fa-8e6c8558bbfa"),
                },
            };
        }
    }
}
