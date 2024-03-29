using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Account;
using PureSound.Data;
using Microsoft.EntityFrameworkCore;
using PureSound.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using PureSound.Data.Entities;
using PureSound.Services;
using PureSound.Contracts;

namespace PureSound.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IPageService pageService;
        private readonly UserManager<User> userManager;

        public PagesController(IPageService _pageService, ApplicationDbContext _context, UserManager<User> _userManager)
        {
            this.pageService = _pageService;
            this.context = _context;
            this.userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> AllEntities()
        {
            var artists = await pageService.GetAllArtistsAsync();
            var tracks = await pageService.GetAllTracksAsync();

            foreach (var track in tracks)
            {
                var artistsIds = context.ArtistTrack.Where(x => x.TrackId == track.Id).Select(x => x.ArtistId).ToList();
                var artistsFromIds = new List<Artist>();
                foreach (var item in artistsIds)
                {
                    var artist = context.Artists.Include(x => x.Genre).FirstOrDefault(x => x.Id == item);
                    artistsFromIds.Add(artist!);
                }
                var artistsNames = artistsFromIds.Select(x => x.Username).ToList();
                ViewBag.ArtistsNames = artistsNames;
            }
            var avms = new List<ArtistVM>();
            var tvms = new List<TrackVM>();

            foreach (var item in artists)
            {
                var avm = new ArtistVM()
                {
                    Id = item.Id,
                    Username = item.Username,
                    ArtistTrack = item.ArtistTrack,
                    ImageURL = item.ImageURL,
                    Age = item.Age,
                    GenreId = item.GenreId,
                    Genre = context.Genres.FirstOrDefault(x => x.Id == item.GenreId)!
                };

                avms.Add(avm);
            }
            foreach (var item in tracks)
            {
                var tvm = new TrackVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                    ArtistTrack = item.ArtistTrack,
                    ImageURL = item.ImageURL,
                    Year = item.Year,
                    YouTubeURL = item.YouTubeURL,
                    GenreId = item.GenreId,
                    Lyrics = item.Lyrics,
                    Genre = context.Genres.FirstOrDefault(x => x.Id == item.GenreId)!
                };

                tvms.Add(tvm);
            }

            ViewBag.Tracks = tvms;
            ViewBag.Artists = avms;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var users = await pageService.GetAllUsersAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> FavouriteArtists()
        {
            var userId = userManager.GetUserId(this.User);
            var forView = await pageService.FavouriteArtistsAsync(Guid.Parse(userId!));
            return View(forView);
        }

        [HttpGet]
        public async Task<IActionResult> FavouriteTracks()
        {
            var userId = userManager.GetUserId(this.User);
            var forView = await pageService.FavouriteTracksAsync(Guid.Parse(userId!));

            return View(forView);
        }

        [HttpPost]
        public async Task<IActionResult> AddRemoveFavorite(Guid artistId, bool isFavorite)
        {
            // Get the current user
            var user = await userManager.GetUserAsync(User);

            // Get the artist
            var artist = await context.Artists.FindAsync(artistId);

            if (artist == null || user == null)
            {
                return Json(new { success = false });
            }

            // Check if the user already has this artist in favorites
            var favorite = await context.FavouriteArtists.FirstOrDefaultAsync(f => f.ArtistId == artistId && f.UserId == Guid.Parse(user.Id));

            if (isFavorite)
            {
                // Add the artist to favorites if not already added
                if (favorite == null)
                {
                    favorite = new FavouriteArtists { UserId = Guid.Parse(user.Id), ArtistId = artistId };
                    context.FavouriteArtists.Add(favorite);
                    await context.SaveChangesAsync();
                }
            }
            else
            {
                // Remove the artist from favorites if already added
                if (favorite != null)
                {
                    context.FavouriteArtists.Remove(favorite);
                    await context.SaveChangesAsync();
                }
            }

            return Json(new { success = true });
        }
    }
}
