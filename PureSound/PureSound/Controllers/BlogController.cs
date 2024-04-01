using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureSound.Data.Account;
using PureSound.Data;
using Microsoft.EntityFrameworkCore;
using PureSound.Models.ViewModels;
using PureSound.Data.Entities;
using PureSound.Contracts;
using PureSound.Services;

namespace PureSound.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IBlogService blogService;

        public BlogController(ApplicationDbContext _context, IBlogService _blogService)
        {
            this.context = _context;
            this.blogService = _blogService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var artist = await context.Artists.ToListAsync();
            var artistsNames = new List<string>();
            foreach (var item in artist)
            {
                var name = item.Username;
                artistsNames.Add(name);
            }
            ViewBag.Artists = artistsNames;
            var tracks = await context.Tracks.ToListAsync();
            var tracksNames = new List<string>();
            foreach (var item in tracks)
            {
                var name = item.Title;
                tracksNames.Add(name);
            }
            ViewBag.Tracks = tracksNames;

            var articles = await blogService.GetAllArticlesAsync();
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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await blogService.AddArticleAsync(model);
                return RedirectToAction("Index", "Blog");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                await blogService.DeleteArticleAsync(id);
                return RedirectToAction("Index", "Blog");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
        }
    }
}
