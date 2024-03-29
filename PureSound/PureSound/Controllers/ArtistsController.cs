using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Account;
using PureSound.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;
using System.Diagnostics;
using PureSound.Contracts;
using PureSound.Services;

namespace PureSound.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IArtistService artistService;
        private readonly UserManager<User> userManager;

        public ArtistsController(IArtistService _artistService, ApplicationDbContext _context, UserManager<User> _userManager)
        {
            this.artistService = _artistService;
            this.context = _context;
            this.userManager = _userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Artists(string sortOption)
        {
            var artists = await artistService.GetAllArtistsAsync();

            artists = await artistService.SortArtistsAsync(sortOption);

            return View(artists);
        }

        [HttpGet]
        public IActionResult AddArtist()
        {
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            ViewBag.RegionId = new SelectList(context.Regions.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddArtist(AddArtistVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await artistService.AddArtistAsync(model);
                return RedirectToAction("Artists", "Artists");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteArtist(Guid id)
        {
            await artistService.DeleteArtistAsync(id);
            return RedirectToAction("AllEntities", "Pages");
        }

        [HttpGet]
        public async Task<IActionResult> EachArtist(Guid id)
        {
            ViewBag.Songs = await artistService.GetArtistsTracksAsync(id);
            var user = userManager.GetUserId(this.User);
            ViewBag.UserId = Guid.Parse(user!);

            var artist = await artistService.GetArtistByIdAsync(id);
            if (artist != null)
            {
                return View(artist);
            }
            else
            {
                return RedirectToAction("Artists", "Artists");
            }
        }
        [HttpPost]
        public async Task AddToFavourite( Guid id)
        {
            var userId = userManager.GetUserId(this.User);
            var artist = await context.Artists.FindAsync(id);

            await artistService.AddToFavouriteAsync(Guid.Parse(userId!), artist!.Id);
            var artistvm = new ArtistVM()
            {
                Id = artist.Id,
                Username = artist.Username,
                Age = artist.Age,
                ArtistTrack = artist.ArtistTrack,
                FavoriteArtists = artist.FavoriteArtists,
                Genre = artist.Genre,
                GenreId = artist.GenreId,
                ImageURL = artist.ImageURL,
                IsLikedByCurrentUser = true,
                Region = artist.Region,
                RegionId = artist.RegionId
            };
            
        }

        [HttpPost]
        public async Task RemoveFromFavourite(Guid id)
        {
            var userId = userManager.GetUserId(this.User);
            var artist = await context.Artists.FindAsync(id);

            await artistService.RemoveFromFavouriteAsync(Guid.Parse(userId!), artist!.Id);

            var artistvm = new ArtistVM()
            {
                Id = artist.Id,
                Username = artist.Username,
                Age = artist.Age,
                ArtistTrack = artist.ArtistTrack,
                FavoriteArtists = artist.FavoriteArtists,
                Genre = artist.Genre,
                GenreId = artist.GenreId,
                ImageURL = artist.ImageURL,
                IsLikedByCurrentUser = false,
                Region = artist.Region,
                RegionId = artist.RegionId
            };
            
        }
    }
}
