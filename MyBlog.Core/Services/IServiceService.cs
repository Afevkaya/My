using MyBlog.Core.DTOs.Response.Service;

namespace MyBlog.Core.Services;

public interface IServiceService
{
    Task<ICollection<ResponseService>> GetsAsync();
    Task<ResponseService> GetAsync(int id);
    Task<ResponseService> InsertAsync(ResponseService entity);
    Task UpdateAsync(ResponseService entity);
    Task RemoveAsync(ResponseService entity);
}
