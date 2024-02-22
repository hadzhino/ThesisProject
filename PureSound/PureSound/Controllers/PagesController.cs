using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Account;
using PureSound.Data;
using Microsoft.EntityFrameworkCore;
using PureSound.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using PureSound.Data.Entities;

namespace PureSound.Controllers
{
    [Authorize]
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public PagesController(SignInManager<User> _signInManager, UserManager<User> _userManager, ApplicationDbContext _context, RoleManager<IdentityRole> _roleManager)
        {
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.context = _context;
            this.roleManager = _roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Artists()
        {
            var artists = await context.Artists.ToListAsync();
            return View(artists);
        }

        [HttpGet]
        public async Task<IActionResult> Tracks()
        {
            var tracks = await context.Songs.ToListAsync();
            return View(tracks);
        }

        [HttpGet]
        public async Task<IActionResult> Albums()
        {
            var albums = await context.Albums.ToListAsync();
            return View(albums);
        }

        [HttpGet]
        public IActionResult AddArtist()
        {
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddArtist(AddArtistVM model)
        {
            var artist = new Artist()
            {
                Id = Guid.NewGuid(),
                Username = model.Username,
                Age = model.Age,
                GenreId = model.GenreId,
                ImageURL = model.ImageURL,
                Albums = model.Albums,
                MainGenre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!
            };
            await context.Artists.AddAsync(artist);
            await context.SaveChangesAsync();
            return RedirectToAction("Artists", "Pages");
        }

        [HttpGet]
        public IActionResult AddTrack()
        {
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            ViewBag.AlbumId = new SelectList(context.Albums.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTrack(AddTrackVM model)
        {
            var track = new Song()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Artists = model.Artists,
                Lyrics = model.Lyrics,
                Year = model.Year,
                ImageURL = model.ImageURL,
                GenreId = model.GenreId,
                AlbumId = model.AlbumId,
                Genre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!,
                Album = context.Albums.FirstOrDefault(x => x.Id == model.AlbumId)!
            };
            await context.Songs.AddAsync(track);
            await context.SaveChangesAsync();
            return RedirectToAction("Tracks", "Pages");
        }

        [HttpGet]
        public IActionResult AddAlbum()
        {
            ViewBag.ArtistId = new SelectList(context.Artists.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAlbum(AddAlbumVM model)
        {
            var album = new Album()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                ArtistId = model.ArtistId,
                Year = model.Year,
                ImageURL = model.ImageURL,
                Songs = model.Songs
            };
            await context.Albums.AddAsync(album);
            await context.SaveChangesAsync();
            return RedirectToAction("Albums", "Pages");
        }
    }
}
