using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;

namespace PureSound.Services
{
    public class TrackService : ITrackService
    {
        private readonly ApplicationDbContext context;
        public TrackService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public async Task<List<TrackVM>> GetAllTracksAsync()
        {
            var tracks = await context.Tracks.Include(x => x.Genre).Include(x => x.ArtistTrack)!.ThenInclude(x => x.Artist).ToListAsync();
            var result = new List<TrackVM>();
            foreach (var t in tracks)
            {
                var tNew = new TrackVM()
                {
                    Id = t.Id,
                    Title = t.Title,
                    Year = t.Year,
                    YouTubeURL = t.YouTubeURL,
                    ImageURL = t.ImageURL,
                    ArtistTrack = t.ArtistTrack,
                    GenreId = t.GenreId,
                    Genre = t.Genre,
                    Lyrics = t.Lyrics,
                    FavoriteTracks = t.FavoriteTracks,
                };
                result.Add(tNew);
            }
            return result;

        }
        public async Task<List<ArtistVM>> GetAllTrackArtistsAsync(Guid id)
        {
            var track = await context.Tracks.FirstOrDefaultAsync(x => x.Id == id);
            var artists = new List<ArtistVM>();
            if (track != null)
            {
                var artistsIds = context.ArtistTrack.Where(x => x.TrackId == track.Id).Select(x => x.ArtistId).ToList();
                foreach (var item in artistsIds)
                {
                    var artist = context.Artists.Include(x => x.Genre).FirstOrDefault(x => x.Id == item);
                    var artistVM = new ArtistVM()
                    {
                        Id = Guid.NewGuid(),
                        Username = artist.Username,
                        Age = artist.Age,
                        GenreId = artist.GenreId,
                        ImageURL = artist.ImageURL,
                        Genre = context.Genres.FirstOrDefault(x => x.Id == artist.GenreId)!,
                        ArtistTrack = artist.ArtistTrack,
                        FavoriteArtists = artist.FavoriteArtists,
                        RegionId = artist.RegionId,
                        Region = context.Regions.FirstOrDefault(x => x.Id == artist.RegionId)!
                    };
                    artists.Add(artistVM!);
                }
            }

            return artists;
        }
        public async Task<List<TrackVM>> SortTracksAsync(string sortOption)
        {
            var tracks = await GetAllTracksAsync();

            switch (sortOption)
            {
                case "By Title (A-Z)":
                    tracks = tracks.OrderBy(x => x.Title).ToList();
                    break;
                case "By Title (Z-A)":
                    tracks = tracks.OrderByDescending(x => x.Title).ToList();
                    break;
                case "By Year (Newest)":
                    tracks = tracks.OrderByDescending(x => x.Year).ToList();
                    break;
                case "By Year (Oldest)":
                    tracks = tracks.OrderBy(x => x.Year).ToList();
                    break;
                case "By Genre (A-Z)":
                    tracks = tracks.OrderBy(x => x.Genre.Name).ToList();
                    break;
                default:
                    tracks = tracks.OrderBy(x => x.Title).ToList();
                    break;
            }
            return tracks;
        }
        public async Task AddTrackAsync(AddTrackVM model)
        {
            var track = new Track()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Lyrics = model.Lyrics,
                Year = model.Year,
                ImageURL = model.ImageURL,
                GenreId = model.GenreId,
                YouTubeURL = model.YouTubeURL,
                Genre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!
            };
            await context.Tracks.AddAsync(track);

            foreach (var item in model.ArtistsIds!)
            {
                var artistTrack = new ArtistTrack()
                {
                    Id = Guid.NewGuid(),
                    ArtistId = item,
                    TrackId = track.Id
                };
                await context.ArtistTrack.AddAsync(artistTrack);
                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();
        }
        public async Task DeleteTrackAsync(Guid id)
        {
            var track = await context.Tracks.Include(x => x.ArtistTrack).ThenInclude(x => x.Artist).FirstOrDefaultAsync(x => x.Id == id);
            context.Tracks.Remove(track);
            var at = await context.ArtistTrack.Where(x => x.TrackId == track.Id).ToListAsync();
            foreach (var item in at)
            {
                context.ArtistTrack.Remove(item);
            }
            await context.SaveChangesAsync();
        }
        public async Task<TrackVM> EachTrackAsync(Guid id)
        {
            var track = await context.Tracks
                .Include(x => x.Genre)
                .Include(x => x.ArtistTrack)!
                .ThenInclude(x => x.Artist)
                .FirstOrDefaultAsync(x => x.Id == id);

            TrackVM vm = null;

            if (track != null)
            {
                vm = new TrackVM()
                {
                    Id = track.Id,
                    Title = track.Title,
                    ImageURL = track.ImageURL,
                    Year = track.Year,
                    Genre = track.Genre,
                    GenreId = track.GenreId,
                    ArtistTrack = track.ArtistTrack!,
                    Lyrics = track.Lyrics,
                    YouTubeURL = track.YouTubeURL,
                    FavoriteTracks = track.FavoriteTracks
                };
            }
            return vm;
        }
    }
}
