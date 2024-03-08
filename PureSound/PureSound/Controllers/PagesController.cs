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
            var artists = await context.Artists.Include(a => a.ArtistSongs).ThenInclude(x => x.Song).ToListAsync();
            return View(artists);
        }

        [HttpGet]
        public async Task<IActionResult> Tracks()
        {
            var tracks = await context.Songs.ToListAsync();
            return View(tracks);
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
                Genre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!,
            };
            await context.Artists.AddAsync(artist);
            await context.SaveChangesAsync();
            return RedirectToAction("Artists", "Pages");
        }

        [HttpGet]
        public IActionResult AddTrack()
        {
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            ViewBag.Artists = new SelectList(context.Artists.ToList(), "Id", "Username");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTrack(AddTrackVM model)
        {

            var track = new Song()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Lyrics = model.Lyrics,
                Year = model.Year,
                ImageURL = model.ImageURL,
                GenreId = model.GenreId,
                Genre = context.Genres.FirstOrDefault(x => x.Id == model.GenreId)!
            };
            await context.Songs.AddAsync(track);

            foreach (var item in model.ArtistsIds)
            {
                var artistSong = new ArtistsSong()
                {
                    Id = Guid.NewGuid(),
                    ArtistId = item,
                    SongId = track.Id
                };
                await context.ArtistsSongs.AddAsync(artistSong);
                await context.SaveChangesAsync();
            }

            await context.SaveChangesAsync();

            return RedirectToAction("Tracks", "Pages");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteArtist(Guid id)
        {
            var artist = await context.Artists.FirstOrDefaultAsync(x => x.Id == id);
            if (artist != null)
            {
                context.Artists.Remove(artist);

                await context.SaveChangesAsync();
                return RedirectToAction("Artists", "Pages");
            }
            return RedirectToAction("Artists", "Pages");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTrack(Guid id)
        {
            var track = context.Songs.FirstOrDefault(x => x.Id == id);
            if (track != null)
            {
                return await Task.Run(() => View("DeleteTrack", track));
            }
            return RedirectToAction("Tracks", "Pages");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrack(DeleteTrackVM model)
        {
            var track = await context.Songs.FindAsync(model.Id);
            if (track != null)
            {
                context.Songs.Remove(track);

                await context.SaveChangesAsync();
                return RedirectToAction("Tracks", "Pages");
            }
            return RedirectToAction("Tracks", "Pages");
        }


        [HttpPost]
        public async Task<IActionResult> SerachArtist(string search)
        {
            ViewBag.Search = search;
            var artists = await context.Artists.Include(a => a.ArtistSongs).ThenInclude(x => x.Song).ToListAsync();
            var artist = artists.FirstOrDefault();
            if (search != null)
            {
                artist = artists.FirstOrDefault(a => a.Username.Contains(search));
                return RedirectToAction("EachArtist", "Pages");
            }
            else
            {
                return RedirectToAction("Artists");
            }

        }


        [HttpPost]
        public async Task<IActionResult> SerachTrack(string search)
        {
            ViewBag.Search = search;
            var tracks = await context.Songs.ToListAsync();
            var track = tracks.FirstOrDefault();
            if (search != null)
            {
                track = tracks.FirstOrDefault(a => a.Title!.Contains(search));
                return RedirectToAction("EachTrack", "Pages");
            }
            else
            {
                return RedirectToAction("Tracks");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EachArtist(Guid id)
        {
            ViewBag.Songs = context.Songs.Include(x=>x.ArtistSong).ThenInclude(x=>x.Artist).Where(x=>x.Id == x.ArtistSong.FirstOrDefault(x=>x.ArtistId == id).Id);
            var artist = await context.Artists.Include(x => x.ArtistSongs)!.ThenInclude(x => x.Song).FirstOrDefaultAsync(x => x.Id == id);
            if (artist != null)
            {
                var vm = new ArtistVM()
                {
                    Id = artist.Id,
                    Username = artist.Username,
                    ImageURL = artist.ImageURL,
                    Age = artist.Age,
                    Genre = artist.Genre,
                    GenreId = artist.GenreId,
                    ArtistsSongs = artist.ArtistSongs
                };
                return View(vm);
            }
            else
            {
                return RedirectToAction("Artists", "Pages");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EachTrack(TrackVM model)
        {
            var track = await context.Songs.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (track != null)
            {
                return View(track);
            }
            else
            {
                return RedirectToAction("Tracks");
            }
        }
    }
}
