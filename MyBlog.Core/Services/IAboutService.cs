using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.About;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.About;

namespace MyBlog.Core.Services;

public interface IAboutService
{
    Task<ApiBaseResponse<List<ResponseAbout>>> GetsAsync();
    Task<ApiBaseResponse<ResponseAbout>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseAbout>> InsertAsync(RequestInsertAbout request);
    Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(ResponseAbout request);
    Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(ResponseAbout request);
}
