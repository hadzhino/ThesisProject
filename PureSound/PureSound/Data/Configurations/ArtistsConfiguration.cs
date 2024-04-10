using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PureSound.Data.Entities;

namespace PureSound.Data.Configurations
{
    public class ArtistsConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Artist> SeedCategories()
        {
            return new List<Artist>()
            {
                new Artist()
                {
                    Id = Guid.Parse("231ff15f-d918-4aa4-8eb7-ad056f6130af"),
                    Age = 30,
                    GenreId = Guid.Parse("f62b7c2d-1cc7-4715-88c5-79c901affbc0"),
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Luciano_2022_crop.jpg/1200px-Luciano_2022_crop.jpg",
                    RegionId = Guid.Parse("1361b02b-40eb-4728-9ca2-8efc1f815ae9"),
                    Username = "Luciao"
                },
                new Artist()
                {
                    Id = Guid.Parse("e6bed5b4-70e9-48d4-b887-5c8339e088bd"),
                    Age = 21,
                    GenreId = Guid.Parse("dc5a739c-1137-4950-9225-57d0c13ed662"),
                    ImageURL = "https://cdns-images.dzcdn.net/images/artist/dfbc7bc0149c8d887da5ac79becb7849/500x500.jpg",
                    RegionId = Guid.Parse("d5510f72-ae7c-4ced-9d1d-bb9f34c49a44"),
                    Username = "Zera"
                },
                new Artist()
                {
                    Id = Guid.Parse("1189c2f4-96b9-41fa-aead-2de6e8f2b4b5"),
                    Age = 21,
                    GenreId = Guid.Parse("b1b61127-eb68-42d4-b80c-494da4d975fe"),
                    ImageURL = "https://yt3.googleusercontent.com/saApY_Wxci9FWnzW2wGQY9BR4L1bXoxI1_vLiynKDAa7a5k0TXwfnBa_GLcTGyvYnzwP4dO8=s900-c-k-c0x00ffffff-no-rj",
                    RegionId = Guid.Parse("d5510f72-ae7c-4ced-9d1d-bb9f34c49a44"),
                    Username = "I.N.I."
                },
                new Artist()
                {
                    Id = Guid.Parse("3032d205-1ade-4e21-91f7-d15845cbeff5"),
                    Age = 37,
                    GenreId = Guid.Parse("046d8ace-f895-4aa5-8c99-6e69433ccef7"),
                    ImageURL = "https://yt3.googleusercontent.com/HEE6U1ojHAjy_QYbnvmtZDNyr5SB5hGynOAyiksZcCBKMFrWanZx0t-FYXNV1uzcRRRvO8Qodw=s900-c-k-c0x00ffffff-no-rj",
                    RegionId = Guid.Parse("d5510f72-ae7c-4ced-9d1d-bb9f34c49a44"),
                    Username = "Inna"
                },
                new Artist()
                {
                    Id = Guid.Parse("1e0677d5-29af-4ba5-b535-312c2b377d46"),
                    Age = 30,
                    GenreId = Guid.Parse("dc5a739c-1137-4950-9225-57d0c13ed662"),
                    ImageURL = "https://media.allure.com/photos/64dfa6396466b2d228974cac/1:1/w_2000,h_2000,c_limit/ariana%20grande%20rem%20foundation%20launch.jpg",
                    RegionId = Guid.Parse("ae75b350-c7bf-4989-8494-37d4520bca9d"),
                    Username = "Ariana Grande"
                },
                new Artist()
                {
                    Id = Guid.Parse("fccdb498-2db4-4d0a-a7ee-85b61398a2cb"),
                    Age = 28,
                    GenreId = Guid.Parse("b1b61127-eb68-42d4-b80c-494da4d975fe"),
                    ImageURL = "https://cdns-images.dzcdn.net/images/artist/5aec6c1118cd7ebe3315a4fe4fece08d/500x500.jpg",
                    RegionId = Guid.Parse("d5510f72-ae7c-4ced-9d1d-bb9f34c49a44"),
                    Username = "Nucci"
                },
            };
        }
    }
}
