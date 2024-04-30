using PureSound.Data.Entities;
using PureSound.Models.ViewModels;
using PureSound.Services;
using PureSoundTests.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PureSoundTests
{
    public class BlogServiceTests
    {
        [Test]
        public async Task AddArticle_AddingArticleCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var categoryId = Guid.NewGuid();


            data.Categories.Add(new Category { Id = categoryId, Name = "Test" });
            var article = new AddArticleVM
            {
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                CategoryId = categoryId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            };
            data.SaveChanges();

            var blogService = new BlogService(data);

            await blogService.AddArticleAsync(article);

            var result = data.Articles.Count();

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public async Task DeleteArticle_DeletingArticleCorrectly()
        {
            using var data = DatabaseMock.Instance;
            var categoryId = Guid.NewGuid();
            var articleId = Guid.NewGuid();

            data.Categories.Add(new Category { Id = categoryId, Name = "Test" });
            var article = new Article
            {
                Id = articleId,
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                CategoryId = categoryId,
                ImageURL = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png"
            };
            data.Articles.Add(article);
            data.SaveChanges();

            var blogService = new BlogService(data);

            await blogService.DeleteArticleAsync(articleId);
            var result = data.Articles.Count();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public async Task ListArticles_GetAllArticlesCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var categoryId = Guid.NewGuid();

            data.Categories.Add(new Category
            {
                Id = categoryId,
                Name = "Test"
            });
            data.Articles.Add(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                CategoryId = categoryId,
                ImageURL = null
            });
            data.SaveChanges();

            var blogService = new BlogService(data);

            var result = await blogService.GetAllArticlesAsync();


            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArticleVM>>());
        }

        [Test]
        public async Task RecentPosts()
        {
            using var data = DatabaseMock.Instance;

            var categoryId = Guid.NewGuid();

            data.Categories.Add(new Category
            {
                Id = categoryId,
                Name = "Test"
            });
            data.Articles.Add(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                CategoryId = categoryId,
                ImageURL = null
            });
            data.SaveChanges();

            var blogService = new BlogService(data);

            var result = await blogService.RecentPostsAsync();


            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArticleVM>>());
        }

        [Test]
        public async Task SortByCategory_SortingArticesCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var categoryId = Guid.NewGuid();
            var categoryId2 = Guid.NewGuid();

            data.Categories.Add(new Category
            {
                Id = categoryId,
                Name = "Test"
            });
            data.Articles.Add(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                CategoryId = categoryId,
                ImageURL = null
            });
            data.Articles.Add(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test2",
                Content = "Test2",
                Date = DateTime.UtcNow,
                CategoryId = categoryId2,
                ImageURL = null
            });
            data.SaveChanges();

            var blogService = new BlogService(data);

            var result = await blogService.SortByCategoryAsync(categoryId);


            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<List<ArticleVM>>());
        }

        [Test]
        public async Task ListComments_GettingCommentsCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var articleId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();
            var genreId = Guid.NewGuid();

            data.Categories.Add(new Category { Id = categoryId, Name = "Test" });
            data.Articles.Add(new Article
            {
                Id = articleId,
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                ImageURL = null,
                CategoryId = categoryId
            });
            data.Users.Add(new PureSound.Data.Account.User
            {
                Id = userId.ToString(),
                Email = "test@gmail.com",
                ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                UserName = "Test",
                FavGenreId = genreId
            });
            data.SaveChanges();

            data.Comments.Add(new Comment
            {
                Id = Guid.NewGuid(),
                ArticleId = articleId,
                Content = "Test",
                UserId = userId.ToString(),
                Date = DateTime.UtcNow
            });
            data.Comments.Add(new Comment
            {
                Id = Guid.NewGuid(),
                ArticleId = articleId,
                Content = "Test",
                UserId = userId.ToString(),
                Date = DateTime.UtcNow
            });
            data.SaveChanges();

            var blogService = new BlogService(data);

            var result = await blogService.GetCommentsAsync(articleId);

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result, Is.TypeOf<List<CommentVM>>());
        }

        [Test]
        public async Task GetArticle_GettingArticleByIdCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var articleId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();

            data.Categories.Add(new Category { Id = categoryId, Name = "Test" });
            data.Articles.Add(new Article
            {
                Id = articleId,
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                ImageURL = null,
                CategoryId = categoryId
            });
            data.SaveChanges();

            var blogService = new BlogService(data);

            var result = await blogService.GetArticleByIdAsync(articleId);

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task CreateComment_CreatingCommentCorrectly()
        {
            using var data = DatabaseMock.Instance;

            var articleId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var categoryId = Guid.NewGuid();
            var genreId = Guid.NewGuid();

            data.Categories.Add(new Category { Id = categoryId, Name = "Test" });
            data.Articles.Add(new Article
            {
                Id = articleId,
                Title = "Test",
                Content = "Test",
                Date = DateTime.UtcNow,
                ImageURL = null,
                CategoryId = categoryId
            });
            data.Users.Add(new PureSound.Data.Account.User
            {
                Id = userId.ToString(),
                Email = "test@gmail.com",
                ImageUrl = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                UserName = "Test",
                FavGenreId = genreId
            });
            data.SaveChanges();

            var comment = new CommentVM
            {
                Id = Guid.NewGuid(),
                ArticleID = articleId,
                Content = "Test",
                Date = DateTime.UtcNow,
                UserId = userId.ToString()
            };

            var blogService = new BlogService(data);
            await blogService.CreateCommentAsync(comment, userId.ToString());

            var result = data.Comments.Count();

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
