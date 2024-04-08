using Microsoft.AspNetCore.Mvc;
using PureSound.Data;
using PureSound.Models.ViewModels;

namespace PureSound.Contracts
{
    public interface IBlogService
    {
        Task<List<ArticleVM>> GetAllArticlesAsync();
        Task AddArticleAsync(AddArticleVM model);
        Task DeleteArticleAsync(Guid id);
        Task<List<ArticleVM>> RecentPostsAsync();
        Task<List<ArticleVM>> SortByCategoryAsync(Guid Id);
        Task<ArticleVM> GetArticleByIdAsync(Guid Id);
    }
}
