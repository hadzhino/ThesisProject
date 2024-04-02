using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;

namespace PureSound.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext context;
        public BlogService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public async Task AddArticleAsync(AddArticleVM model)
        {
            var article = new Article()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Comments = model.Comments,
                Content = model.Content,
                CategoryId = model.CategoryId,
                Category = context.Categories.FirstOrDefault(x => x.Id == model.CategoryId)!,
                Date = DateTime.Today,
                ImageURL = model.ImageURL
            };
            await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
        }

        public async Task DeleteArticleAsync(Guid id)
        {
            var article = await context.Articles.Include(x => x.Comments).Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            context.Articles.Remove(article!);
            await context.SaveChangesAsync();
        }

        public async Task<List<ArticleVM>> GetAllArticlesAsync()
        {
            var articles = await context.Articles.Include(x => x.Comments).Include(x => x.Category).ToListAsync();

            var toReturn = new List<ArticleVM>();
            foreach (var article in articles)
            {
                var art = new ArticleVM()
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content,
                    ImageURL = article.ImageURL,
                    Comments = article.Comments,
                    Date = DateTime.Now,
                    CategoryId = article.CategoryId,
                    Category = context.Categories.FirstOrDefault(x => x.Id == article.CategoryId)!
                };
                toReturn.Add(art);
            }

            return toReturn;
        }
        public async Task<List<ArticleVM>> RecentPostsAsync()
        {
            var posts = await GetAllArticlesAsync();
            posts = posts.OrderBy(x => x.Date).Take(5).ToList();
            return posts;
        }
        public async Task<List<ArticleVM>> SortByCategoryAsync(Guid id)
        {
            var articles = await context.Articles.Include(x => x.Category).Where(x => x.CategoryId == id).ToListAsync();

            var toReturn = new List<ArticleVM>();
            foreach (var item in articles)
            {
                var article = new ArticleVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Content = item.Content,
                    ImageURL = item.ImageURL,
                    Comments = item.Comments,
                    Date = DateTime.Now,
                    CategoryId = item.CategoryId,
                    Category = context.Categories.FirstOrDefault(x => x.Id == item.CategoryId)!
                };
                toReturn.Add(article);
            }

            return toReturn;
        }
    }
}
