using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PureSound.Data;
using PureSound.Models;
using PureSound.Models.ViewModels;
using System.Diagnostics;

namespace PureSound.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await context.Articles.Include(x => x.Category).ToListAsync();
            var toreturn = new List<ArticleVM>();
            foreach (var item in articles)
            {
                var art = new ArticleVM()
                {
                    Id= item.Id,
                    Title = item.Title,
                    Category= item.Category,
                    CategoryId= item.CategoryId,
                    Comments= item.Comments,
                    Content= item.Content,
                    Date = item.Date,
                    ImageURL= item.ImageURL
                };
                toreturn.Add(art);
            }


            return View(toreturn);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}