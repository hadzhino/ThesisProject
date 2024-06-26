﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Account;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;

namespace PureSound.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IBlogService blogService;
        private readonly UserManager<User> userManager;

        public BlogController(ApplicationDbContext _context, IBlogService _blogService, UserManager<User> _userManager)
        {
            this.context = _context;
            this.blogService = _blogService;
            this.userManager = _userManager;
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
                tracksNames.Add(name!);
            }
            ViewBag.Tracks = tracksNames;

            var categories = await context.Categories.Include(x => x.Articles).ToListAsync();
            ViewBag.Categories = categories;

            var recent = await blogService.RecentPostsAsync();
            ViewBag.Recent = recent;

            var articles = await blogService.GetAllArticlesAsync();
            var comments = await context.Comments.ToListAsync();

            return View(articles);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.CategoryId = new SelectList(context.Categories.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
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

        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                await blogService.DeleteArticleAsync(id);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", "Blog");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> SortByCategory(Guid id)
        {
            var articles = await blogService.SortByCategoryAsync(id);
            var categories = await context.Categories.Include(x => x.Articles).ToListAsync();
            ViewBag.Categories = categories;
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
                tracksNames.Add(name!);
            }
            ViewBag.Tracks = tracksNames;
            var all = await blogService.GetAllArticlesAsync();
            ViewBag.Articles = all.Count;
            return View(articles);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CommentVM commentVM)
        {
            var userId = userManager.GetUserId(this.User);
            await blogService.CreateCommentAsync(commentVM, userId!.ToString());
            var comments = await blogService.GetCommentsAsync(commentVM.ArticleID);
            var articleId = commentVM.ArticleID;
            return RedirectToAction("EachArticle", new { id = articleId });
        }

        [HttpGet]
        public async Task<IActionResult> EachArticle(Guid id)
        {
            var article = await blogService.GetArticleByIdAsync(id);
            ViewBag.UserID = userManager.GetUserId(this.User);
            return View(article);
        }

        [HttpGet]
        public async Task<IActionResult> TagFilteredPosts(string tag)
        {
            var articles = await blogService.GetAllArticlesAsync();
            articles = articles.Where(x => x.Title.ToLower().Contains(tag.ToLower()) || x.Content.ToLower().Contains(tag.ToLower())).ToList();

            var categories = await context.Categories.Include(x => x.Articles).ToListAsync();
            ViewBag.Categories = categories;
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
                tracksNames.Add(name!);
            }
            ViewBag.Tracks = tracksNames;
            var all = await blogService.GetAllArticlesAsync();
            ViewBag.Articles = all.Count;

            return View(articles);
        }
    }
}
