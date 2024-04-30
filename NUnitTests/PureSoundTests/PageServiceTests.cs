using PureSound.Data.Account;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;
using PureSound.Services;
using PureSoundTests.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureSoundTests
{
    public class PageServiceTests
    {
        [Test]
        public async Task ListAllTracks_ReturnsAllTracksCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var genreId = Guid.NewGuid();

            data.Tracks.Add(new Track
            {
                Id = Guid.NewGuid(),
                Title = "Title",
                GenreId = genreId,
                Year = 2024,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Genre = new Genre
                {
                    Id = genreId,
                    Name = "Test"
                },
                Lyrics = "test",
                YouTubeURL = "https://www.youtube.com/watch?v=RXBbgxD8VdQ&list=RDMM&index=26"
            });

            data.SaveChanges();

            var pageService = new PageService(data);

            var result = await pageService.GetAllTracksAsync();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<TrackVM>>());
        }
        [Test]
        public async Task ListAllArtists_ReturnsAllArtistsCorrectly()
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

            var pageService = new PageService(data);

            var result = await pageService.GetAllArtistsAsync();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArtistVM>>());
        }
        [Test]
        public async Task ListAllUsers_ReturnsAllUsersCorrectly()
        {
            var userId = Guid.NewGuid();
            var genreId = Guid.NewGuid();

            using var data = DatabaseMock.Instance;

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
            data.SaveChanges();

            var pageService = new PageService(data);

            var result = await pageService.GetAllUsersAsync();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<UserVM>>());
        }

        [Test]
        public async Task ListFavouriteTracks_ReturnsUserFavouritesCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var userId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var trackId = Guid.NewGuid();

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

            data.Tracks.Add(new Track
            {
                Id = trackId,
                Title = "Title",
                GenreId = genreId,
                Year = 2024,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                Lyrics = "test",
                YouTubeURL = "https://www.youtube.com/watch?v=RXBbgxD8VdQ&list=RDMM&index=26"
            });
            data.SaveChanges();

            var service = new TrackService(data);
            await service.AddToFavouriteAsync(userId, trackId);

            var pageService = new PageService(data);

            var result = await pageService.FavouriteTracksAsync(userId);

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<TrackVM>>());
        }

        [Test]
        public async Task ListFavouriteArtists_ReturnsUserFavouritesCorrectly()
        {
            var userId = Guid.NewGuid();
            var artistId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var regionId = Guid.NewGuid();

            using var data = DatabaseMock.Instance;

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
            var service = new ArtistService(data);
            await service.AddToFavouriteAsync(userId, artistId);

            var pageService = new PageService(data);

            var result = await pageService.FavouriteArtistsAsync(userId);

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArtistVM>>());
        }
    }
}
