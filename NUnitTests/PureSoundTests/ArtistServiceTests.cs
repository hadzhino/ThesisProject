using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Storage;
using Moq;
using NuGet.Frameworks;
using PureSound.Data.Account;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;
using PureSound.Services;
using PureSoundTests.Mock;

namespace PureSoundTests
{
    public class ArtistServiceTests
    {

        [Test]
        public async Task ListArtists_ReturnsAllArtistsCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();
            data.Artists.Add(new Artist
            {
                Id = Guid.NewGuid(),
                Username = "Test",
                Age = 20,
                GenreId = genreId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Genre = new Genre
                {
                    Id = genreId,
                    Name = "Test"
                },
                RegionId = regionId,
                Region = new Region
                {
                    Id = regionId,
                    Name = "Test"
                }
            });
            data.SaveChanges();

            var artistService = new ArtistService(data);

            var result = await artistService.GetAllArtistsAsync();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArtistVM>>());
        }

        [Test]
        public async Task GetArtists_ReturnsArtistByIdCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var artistId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();
            data.Artists.Add(new Artist
            {
                Id = artistId,
                Username = "Test",
                Age = 20,
                GenreId = genreId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Genre = new Genre
                {
                    Id = genreId,
                    Name = "Test"
                },
                RegionId = regionId,
                Region = new Region
                {
                    Id = regionId,
                    Name = "Test"
                },
            });
            data.SaveChanges();

            var artistService = new ArtistService(data);

            var artist = await artistService.GetArtistByIdAsync(artistId);

            Assert.IsNotNull(artist);
        }

        [Test]
        public void GetArtist_ThrowsNullExceptionIfGivenWrongArtistId()
        {
            var data = DatabaseMock.Instance;

            var artistService = new ArtistService(data);

            var ex = Assert.ThrowsAsync<NullReferenceException>(async ()
               => await artistService.GetArtistByIdAsync(Guid.NewGuid()));
        }

        [Test]
        public async Task AddToFavouriteAsync_WhenCalled_ShouldAddToFavorites()
        {
            var userId = Guid.NewGuid();
            var artistId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();

            var data = DatabaseMock.Instance;

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
            data.Users.Add(new User
            {
                Id = userId.ToString(),
                UserName = "Test",
                Email = "test@gmail.com",
                FavGenreId = genreId,
                FavGenre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
            });

            data.Artists.Add(new Artist
            {
                Id = artistId,
                Age = 30,
                GenreId = genreId,
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Username = "Test",
                RegionId = regionId,
                Region = new Region()
                {
                    Id = regionId,
                    Name = "Test",
                }
            });
            var user = data.Users.FirstOrDefault(x => x.Id == userId.ToString());
            var service = new ArtistService(data);

            // Act
            await service.AddToFavouriteAsync(userId, artistId);

            // Check if the FavouriteCount of the artist was updated
            Assert.AreEqual(1, data.FavouriteArtists.Count(), "FavouriteCount of the artist should be incremented to 1.");
        }

        [Test]
        public async Task RemoveFromFavourite_RemovingArtistToFavouriteCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var artistId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
            data.Artists.Add(new Artist
            {
                Id = artistId,
                Username = "Test",
                Age = 20,
                GenreId = genreId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                RegionId = regionId,
                Region = new Region
                {
                    Id = regionId,
                    Name = "Test"
                },
            });
            data.Users.Add(new User
            {
                Id = userId.ToString(),
                Email = "test@gmai.com",
                FavGenreId = genreId,
                FavGenre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                UserName = "Test",
            });
            data.SaveChanges();

            var artistService = new ArtistService(data);
            await artistService.AddToFavouriteAsync(userId, artistId);
            await artistService.RemoveFromFavouriteAsync(userId, artistId);

            var result = data.FavouriteArtists.Count();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public async Task AddArtist_AddingArtistCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
            data.Regions.Add(new Region { Id = regionId, Name = "Test" });
            var artist = new AddArtistVM
            {
                Age = 30,
                GenreId = genreId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                RegionId = regionId,
                Username = "Test",
            };
            data.SaveChanges();

            var artistService = new ArtistService(data);

            await artistService.AddArtistAsync(artist);

            var result = data.Artists.Count();

            Assert.That(result, Is.EqualTo(1));
        }
    }
}