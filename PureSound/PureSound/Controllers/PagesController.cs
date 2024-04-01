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
using System.Diagnostics;

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

            foreach (var track in forView)
            {
                var artistsIds = context.ArtistTrack.Where(x => x.TrackId == track.Id).Select(x => x.ArtistId).ToList();
                var artists = new List<Artist>();
                foreach (var item in artistsIds)
                {
                    var artist = context.Artists.Include(x => x.Genre).FirstOrDefault(x => x.Id == item);
                    artists.Add(artist!);
                }
                var artistsNames = artists.Select(x => x.Username).ToList();
                ViewBag.Artists = artistsNames;
            }

            return View(forView);
        }
    }
}
