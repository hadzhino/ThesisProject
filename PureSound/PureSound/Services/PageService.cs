using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Account;
using PureSound.Models.ViewModels;

namespace PureSound.Services
{
    public class PageService : IPageService
    {
        private readonly ApplicationDbContext context;
        public PageService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public async Task<List<TrackVM>> GetAllTracksAsync()
        {
            var tracks = await context.Tracks.Include(x => x.Genre).Include(x => x.ArtistTrack)!.ThenInclude(x => x.Artist).ToListAsync();

            var toReturn = new List<TrackVM>();

            foreach (var track in tracks)
            {
                var item = new TrackVM()
                {
                    Id = track.Id,
                    Title = track.Title,
                    Year = track.Year,
                    ArtistTrack = track.ArtistTrack!,
                    FavoriteTracks = track.FavoriteTracks,
                    Genre = track.Genre,
                    GenreId = track.GenreId,
                    Lyrics = track.Lyrics,
                    ImageURL = track.ImageURL,
                    YouTubeURL = track.YouTubeURL
                };
                toReturn.Add(item);
            }

            return toReturn;
        }

        public async Task<List<ArtistVM>> GetAllArtistsAsync()
        {
            var artists = await context.Artists.Include(a => a.ArtistTrack)!.ThenInclude(x => x.Track).ToListAsync();

            var toReturn = new List<ArtistVM>();

            foreach (var artist in artists)
            {
                var item = new ArtistVM()
                {
                    Id= artist.Id,
                    Username= artist.Username,
                    Age= artist.Age,
                    ArtistTrack = artist.ArtistTrack,
                    ImageURL= artist.ImageURL,
                    FavoriteArtists = artist.FavoriteArtists,
                    RegionId = artist.RegionId,
                    Region = artist.Region,
                    Genre = artist.Genre,
                    GenreId = artist.GenreId
                };
                toReturn.Add(item);
            }
            return toReturn;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = await context.Users.Include(x => x.FavGenre).Include(x => x.FavouriteArtists).Include(x => x.FavouriteTracks).ToListAsync();
            return users;
        }
    }
}
