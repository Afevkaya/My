using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Service;

namespace MyBlog.Core.Services;

public interface IServiceService
{
    Task<ICollection<ApiBaseResponse<ResponseService>>> GetsAsync();
    Task<ApiBaseResponse<ResponseService>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseService>> InsertAsync(ResponseService entity);
    Task UpdateAsync(ResponseService entity);
    Task RemoveAsync(ResponseService entity);
}
