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

        public async Task<List<TrackVM>> FavouriteTracksAsync(Guid id)
        {
            var tracks = await context.FavouriteTracks
                 .Include(x => x.Track)
                 .Include(x => x.Track)
                 .ThenInclude(x => x.Genre)
                 .ToListAsync();

            tracks = tracks.Where(x => x.UserId == id).ToList();
            var toReturn = new List<TrackVM>();

            foreach (var track in tracks)
            {
                var tr = new TrackVM()
                {
                    Id = track.Track.Id,
                    Title = track.Track.Title,
                    ArtistTrack = track.Track.ArtistTrack!,
                    FavoriteTracks = track.Track.FavoriteTracks,
                    Genre = track.Track.Genre,
                    GenreId = track.Track.GenreId,
                    ImageURL = track.Track.ImageURL,
                    Lyrics = track.Track.Lyrics,
                    Year = track.Track.Year,
                    YouTubeURL = track.Track.YouTubeURL
                };
                toReturn.Add(tr);
            }

            return toReturn;
        }

        public async Task<List<ArtistVM>> FavouriteArtistsAsync(Guid id)
        {
            var artists = await context.FavouriteArtists
                .Include(x=>x.Artist)
                .Include(x=>x.Artist)
                .ThenInclude(x=>x.Genre)
                .Include(x=>x.Artist)
                .ThenInclude(x=>x.Region)
                .ToListAsync();

            artists = artists.Where(x=>x.UserId == id).ToList();
            var toReturn = new List<ArtistVM>();

            foreach (var artist in artists)
            {
                var art = new ArtistVM()
                {
                    Id = artist.Artist.Id,
                    Username = artist.Artist.Username,
                    Region = artist.Artist.Region,
                    RegionId = artist.Artist.RegionId,
                    ImageURL = artist.Artist.ImageURL,
                    GenreId = artist.Artist.GenreId,
                    Age = artist.Artist.Age,
                    ArtistTrack = artist.Artist.ArtistTrack,
                    FavoriteArtists = artist.Artist.FavoriteArtists,
                    Genre = artist.Artist.Genre
                };
                toReturn.Add(art);
            }

            return toReturn;
        }
    }
}
