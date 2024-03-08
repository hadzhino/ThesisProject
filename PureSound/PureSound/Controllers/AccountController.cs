using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PureSound.Data;
using PureSound.Data.Account;
using PureSound.Data.Entities;
using PureSound.Models.Account;

namespace PureSound.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(SignInManager<User> _signInManager, UserManager<User> _userManager, ApplicationDbContext _context, RoleManager<IdentityRole> _roleManager)
        {
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.context = _context;
            this.roleManager = _roleManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            var model = new RegisterVM();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (model == null)
            {
                return View(model);
            }
            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                FavGenreId = model.GenreId,
                FavGenre = context.Genres.Where(x => x.Id == model.GenreId).FirstOrDefault()!
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "USER");
                return RedirectToAction("Login", "Account");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginVM();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var user = await userManager.GetUserAsync(this.User);
            user!.FavGenre = context.Genres.FirstOrDefault(x => x.Id == user.FavGenreId)!;
            return View(user);
        }

        [HttpGet]
        public IActionResult ProfilePhoto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ProfilePhoto(ProfilePhotoVM model)
        {
            var user = await userManager.GetUserAsync(this.User);
            user!.ImageUrl = model.ImageUrl;
            await context.SaveChangesAsync();
            return RedirectToAction("MyProfile", "Account");
        }

        [HttpGet]
        public async Task<IActionResult> FavouriteArtists()
        {
            var user = await userManager.GetUserAsync(this.User);
            var favArtists = user!.FavArtists.ToList();
            return View(favArtists);
        }
        [HttpGet]
        public async Task<IActionResult> FavouriteTracks()
        {
            var user = await userManager.GetUserAsync(this.User);
            var favTracks = user!.FavSongs.ToList();
            return View(favTracks);
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var users = await context.Users.ToListAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> AllEntities()  
        {
            var entities = await context.Artists.Include(x => x.ArtistSongs)!.ThenInclude(x => x.Song).ToListAsync();
            ViewBag.Entities = entities;
            return View(entities);
        }
    }
}
