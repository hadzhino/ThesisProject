using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Account;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;

namespace PureSound.Services
{
    public class ArtistService : IArtistService
    {
        private readonly ApplicationDbContext context;
        public ArtistService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public async Task<ArtistVM> GetArtistByIdAsync(Guid id)
        {
            var artist = await context.Artists.Include(x => x.Region).Include(x => x.Genre).Include(x => x.ArtistTrack)!.ThenInclude(x => x.Track).FirstOrDefaultAsync(x => x.Id == id);

            var vm = new ArtistVM()
            {
                Id = artist.Id,
                Username = artist.Username,
                Age = artist.Age,
                GenreId = artist.GenreId,
                ImageURL = artist.ImageURL,
                Genre = context.Genres.FirstOrDefault(x => x.Id == artist.GenreId)!,
                Region = artist.Region,
                RegionId = artist.RegionId,
                FavoriteArtists = artist.FavoriteArtists,
                ArtistTrack = artist.ArtistTrack
            };

            return vm;
        }
        public async Task<List<ArtistVM>> GetAllArtistsAsync()
        {
            var artists = await context.Artists.Include(x => x.Genre).Include(x => x.Region).Include(a => a.ArtistTrack)!.ThenInclude(x => x.Track).ToListAsync();

            var result = new List<ArtistVM>();
            foreach (var a in artists)
            {
                var tNew = new ArtistVM()
                {
                    Id = a.Id,
                    Username = a.Username,
                    Age = a.Age,
                    GenreId = a.GenreId,
                    ImageURL = a.ImageURL,
                    Genre = context.Genres.FirstOrDefault(x => x.Id == a.GenreId)!,
                    ArtistTrack = a.ArtistTrack,
                    Region = context.Regions.FirstOrDefault(x => x.Id == a.RegionId),
                    RegionId = a.RegionId,
                    FavoriteArtists = a.FavoriteArtists
                };
                result.Add(tNew);
            }
            return result;
        }
        public async Task<List<ArtistVM>> SortArtistsAsync(string sortOption)
        {
            var artists = await GetAllArtistsAsync();

            switch (sortOption)
            {
                case "By Username (A-Z)":
                    artists = artists.OrderBy(x => x.Username).ToList();
                    break;
                case "By Username (Z-A)":
                    artists = artists.OrderByDescending(x => x.Username).ToList();
                    break;
                case "By Main Genre":
                    artists = artists.OrderBy(x => x.Genre.Name).ToList();
                    break;
                default:
                    artists = artists.OrderByDescending(x => x.Username).ToList();
                    break;
            }

            return artists;
        }
        public async Task AddArtistAsync(AddArtistVM model)
        {
            var artist = new Artist()
            {
                Id = Guid.NewGuid(),
                Username = model.Username,
                Age = model.Age,
                GenreId = model.GenreId,
                ImageURL = model.ImageURL,
                Genre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!,
                RegionId = model.RegionId,
                Region = context.Regions.FirstOrDefault(x => x.Id == model.RegionId)!
            };
            await context.Artists.AddAsync(artist);
            await context.SaveChangesAsync();
        }
        public async Task DeleteArtistAsync(Guid id)
        {
            var vm = await context.Artists.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (vm != null)
            {
                var artist = new Artist()
                {
                    Id = vm.Id,
                    Username = vm.Username,
                    Age = vm.Age,
                    GenreId = vm.GenreId,
                    ImageURL = vm.ImageURL,
                    Genre = context.Genres.FirstOrDefault(x => x.Id == vm.GenreId)!,
                    ArtistTrack = vm.ArtistTrack,
                    RegionId = vm.RegionId,
                    Region = context.Regions.FirstOrDefault(x => x.Id == vm.RegionId)!,
                    FavoriteArtists = vm.FavoriteArtists
                };

                context.Artists.Remove(artist);
                await context.SaveChangesAsync();

            }
        }
        public async Task<List<Track>> GetArtistsTracksAsync(Guid id)
        {
            var songsIds = await context.ArtistTrack.Where(x => x.ArtistId == id).Select(x => x.TrackId).ToListAsync();
            var songs = new List<Track>();
            foreach (var item in songsIds)
            {
                var song = await context.Tracks.Include(x => x.Genre).FirstOrDefaultAsync(x => x.Id == item);
                songs.Add(song!);
            }

            return songs;
        }
        public async Task AddToFavouriteAsync(Guid userId, Guid artistId)
        {
            var user = await context.Users.FindAsync(Convert.ToString(userId));
            var artist = await context.Artists.FindAsync(artistId);

            var favArtist = new FavouriteArtists()
            {
                Id = Guid.NewGuid(),
                ArtistId = artist!.Id,
                UserId = Guid.Parse(user!.Id)
            };

            context.FavouriteArtists.Add(favArtist);
            await context.SaveChangesAsync();
        }
        public async Task RemoveFromFavouriteAsync(Guid userId, Guid artistId)
        {
            var user = await context.Users.FindAsync(Convert.ToString(userId));
            var artist = await context.Artists.FindAsync(artistId);
            var favArtist = await context.FavouriteArtists.FirstOrDefaultAsync(x => x.ArtistId == artist!.Id && x.UserId == Guid.Parse(user!.Id));

            context.FavouriteArtists.Remove(favArtist!);
            await context.SaveChangesAsync();
        }
    }
}
