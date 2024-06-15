using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Service;

namespace MyBlog.Core.Services;

public interface IServiceService
{
    Task<ApiBaseResponse<List<ResponseService>>> GetsAsync();
    Task<ApiBaseResponse<ResponseService>> GetAsync(int id);
    // Task<ApiBaseResponse<ResponseService>> InsertAsync(RequestInsertService request);
    // Task<ResponseNoContent> UpdateAsync(ResponseService entity);
    // Task<ResponseNoContent> RemoveAsync(ResponseService entity);
}
