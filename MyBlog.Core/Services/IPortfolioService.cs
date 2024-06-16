using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Portfolio;

namespace MyBlog.Core.Services;

public interface IPortfolioService
{
    Task<ApiBaseResponse<List<ResponsePortfolio>>> GetsAsync();
    // Task<ApiBaseResponse<ResponsePortfolio>> GetAsync(int id);
    // Task<ApiBaseResponse<ResponsePortfolio>> InsertAsync(ResponsePortfolio entity);
    // Task UpdateAsync(ResponsePortfolio entity);
    // Task RemoveAsync(ResponsePortfolio entity);
}
