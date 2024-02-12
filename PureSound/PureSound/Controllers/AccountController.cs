using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PureSound.Data;
using PureSound.Data.Account;
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
                UserName = model.Username,
                GenreId = model.GenreId
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
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
            var user = await userManager.FindByNameAsync(model.Username);
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

        public async Task<IActionResult> CreateRoles()
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
            await roleManager.CreateAsync(new IdentityRole("User"));

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> GiveRoles()
        {
            string usernameAdmin = "Hadzhinho";
            var admin = await userManager.FindByNameAsync(usernameAdmin);
            await userManager.AddToRoleAsync(admin!, "Admin");

            var user = userManager.GetUserAsync(this.User);
            await userManager.AddToRoleAsync(await user, "User");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            return View();
        }
    }
}
