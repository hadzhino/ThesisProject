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
                Date = DateTime.Now,
                ImageURL = model.ImageURL
            };
            await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
        }

        public async Task DeleteArticleAsync(Guid id)
        {
            var article = await context.Articles.Include(x => x.Comments).FirstOrDefaultAsync(x => x.Id == id);
            context.Articles.Remove(article!);
            await context.SaveChangesAsync();
        }

        public async Task<List<ArticleVM>> GetAllArticlesAsync()
        {
            var articles = await context.Articles.Include(x => x.Comments).ToListAsync();

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
                    Date = DateTime.Now
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
    }
}
