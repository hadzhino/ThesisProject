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
using static System.Net.WebRequestMethods;

namespace PureSoundTests
{
    public class TrackServiceTests
    {
        [Test]
        public async Task ListTracks_ReturnsAllTracksCorrectly()
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

            var trackService = new TrackService(data);

            var result = await trackService.GetAllTracksAsync();

            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<TrackVM>>());
        }

        [Test]
        public async Task EachTrack_ReturnsTrackByIdCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var genreId = Guid.NewGuid();
            var trackId = Guid.NewGuid();

            data.Tracks.Add(new Track
            {
                Id = trackId,
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

            var trackService = new TrackService(data);

            var result = await trackService.EachTrackAsync(trackId);

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task AddToFavouriteAsync_WhenCalled_ShouldAddToFavorites()
        {
            var userId = Guid.NewGuid();
            var trackId = Guid.NewGuid();
            var genreId = Guid.NewGuid();

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

            Assert.AreEqual(1, data.FavouriteTracks.Count());
        }

        [Test]
        public async Task RemoveFromFavourite_RemovingArtistToFavouriteCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var trackId = Guid.NewGuid();
            var genreId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
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

            var trackService = new TrackService(data);
            await trackService.AddToFavouriteAsync(userId, trackId);
            await trackService.RemoveFromFavouriteAsync(userId, trackId);

            var result = data.FavouriteArtists.Count();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public async Task AddTrack_AddingTrackCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var genreId = Guid.NewGuid();
            var artist1Id = Guid.NewGuid();
            var artist2Id = Guid.NewGuid();
            var regionId = Guid.NewGuid();

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
            data.Regions.Add(new Region { Id = regionId, Name = "Test" });

            data.Artists.Add(new Artist
            {
                Id = artist1Id,
                Age = 20,
                GenreId = genreId,
                Genre = data.Genres.FirstOrDefault(x=>x.Id==genreId)!,
                RegionId = regionId,
                Region = data.Regions.FirstOrDefault(x=>x.Id==regionId)!,
                Username = "Test1",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            });
            data.Artists.Add(new Artist
            {
                Id = artist2Id,
                Age = 20,
                GenreId = genreId,
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                RegionId = regionId,
                Region = data.Regions.FirstOrDefault(x => x.Id == regionId)!,
                Username = "Test2",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            });

            var Track = new AddTrackVM
            {
                Year = 2020,
                GenreId = genreId,
                Lyrics = "yally yally yally",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Title = "Test",
                YouTubeURL = "https://www.youtube.com/watch?v=RXBbgxD8VdQ&list=RDMM&index=26",
                ArtistsIds = new HashSet<Guid> { artist1Id, artist2Id }
            };
            data.SaveChanges();


            var trackService = new TrackService(data);

            await trackService.AddTrackAsync(Track);

            var result = data.Tracks.Count();

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public async Task DeleteTrack_DeletingTrackCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var genreId = Guid.NewGuid();
            var artist1Id = Guid.NewGuid();
            var artist2Id = Guid.NewGuid();
            var regionId = Guid.NewGuid();

            data.Genres.Add(new Genre { Id = genreId, Name = "Test" });
            data.Regions.Add(new Region { Id = regionId, Name = "Test" });

            data.Artists.Add(new Artist
            {
                Id = artist1Id,
                Age = 20,
                GenreId = genreId,
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                RegionId = regionId,
                Region = data.Regions.FirstOrDefault(x => x.Id == regionId)!,
                Username = "Test1",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            });
            data.Artists.Add(new Artist
            {
                Id = artist2Id,
                Age = 20,
                GenreId = genreId,
                Genre = data.Genres.FirstOrDefault(x => x.Id == genreId)!,
                RegionId = regionId,
                Region = data.Regions.FirstOrDefault(x => x.Id == regionId)!,
                Username = "Test2",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            });

            var Track = new AddTrackVM
            {
                Year = 2020,
                GenreId = genreId,
                Lyrics = "yally yally yally",
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                Title = "Test",
                YouTubeURL = "https://www.youtube.com/watch?v=RXBbgxD8VdQ&list=RDMM&index=26",
                ArtistsIds = new HashSet<Guid> { artist1Id, artist2Id }
            };
            data.SaveChanges();


            var trackService = new TrackService(data);

            await trackService.AddTrackAsync(Track);

            var track = data.Tracks.FirstOrDefault();
            var trackId = track!.Id;

            await trackService.DeleteTrackAsync(trackId);
            var result = data.Tracks.Count();

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
