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
        public async Task<IActionResult> AllEntities()
        {
            var artists = await context.Artists.Include(a => a.ArtistTrack)!.ThenInclude(x => x.Track).ToListAsync();
            var tracks = await context.Tracks.Include(x => x.Genre).Include(x => x.ArtistTrack)!.ThenInclude(x => x.Artist).ToListAsync();
            ViewBag.Artists = artists;
            ViewBag.Tracks = tracks;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var users = await context.Users.Include(x => x.FavGenre).Include(x => x.FavArtists).Include(x => x.FavSongs).ToListAsync();
            return View(users);
        }
    }
}
