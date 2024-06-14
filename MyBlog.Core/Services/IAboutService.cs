using MyBlog.Core.DTOs.Response.About;

namespace MyBlog.Core.Services;

public interface IAboutService
{
    Task<ICollection<ResponseAbout>> GetsAsync();
    Task<ResponseAbout> GetAsync(int id);
    Task<ResponseAbout> InsertAsync(ResponseAbout entity);
    Task UpdateAsync(ResponseAbout entity);
    Task RemoveAsync(ResponseAbout entity);
}
