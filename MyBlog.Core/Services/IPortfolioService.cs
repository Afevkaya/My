using MyBlog.Core.DTOs.Response.Portfolio;

namespace MyBlog.Core.Services;

public interface IPortfolioService
{
    Task<ICollection<ResponsePortfolio>> GetsAsync();
    Task<ResponsePortfolio> GetAsync(int id);
    Task<ResponsePortfolio> InsertAsync(ResponsePortfolio entity);
    Task UpdateAsync(ResponsePortfolio entity);
    Task RemoveAsync(ResponsePortfolio entity);
}
