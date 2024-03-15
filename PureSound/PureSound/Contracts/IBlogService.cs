using Microsoft.AspNetCore.Mvc;
using PureSound.Data;
using PureSound.Models.ViewModels;

namespace PureSound.Contracts
{
    public interface IBlogService
    {
        Task<IEnumerable<ArticleVM>> GetAllArticlesAsync();
        Task<IActionResult> AddArticlesAsync(AddArticleVM model);
        Task<IActionResult> DeleteArticlesAsync(Guid id);
    }
}
