using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Portfolio;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Portfolio;

namespace MyBlog.Core.Services;

public interface IPortfolioService
{
    Task<ApiBaseResponse<List<ResponsePortfolio>>> GetsAsync();
    // Task<ApiBaseResponse<ResponsePortfolio>> GetAsync(int id);
    Task<ApiBaseResponse<ResponsePortfolio>> InsertAsync(RequestInsertPortfolio request);
    // Task UpdateAsync(ResponsePortfolio entity);
    // Task RemoveAsync(ResponsePortfolio entity);
}
