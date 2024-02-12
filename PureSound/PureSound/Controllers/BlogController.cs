using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Account;
using PureSound.Data;
using Microsoft.EntityFrameworkCore;
using PureSound.Models.ViewModels;
using PureSound.Data.Entities;

namespace PureSound.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public BlogController(SignInManager<User> _signInManager, UserManager<User> _userManager, ApplicationDbContext _context, RoleManager<IdentityRole> _roleManager)
        {
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.context = _context;
            this.roleManager = _roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var articles = await context.Articles.Include(x => x.Comments).ToListAsync();
            return View(articles);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddArticleVM model)
        {
            var article = new Article()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Content = model.Content,
                ImageURL = model.ImageURL,
                Date = DateTime.Now,
                Comments = null!
            };
            await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Blog");
        }
    }
}
