using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IAboutService
{
    Task<ICollection<About>> GetsAsync();
    Task<About> GetAsync(int id);
    Task<About> InsertAsync(About entity);
    Task UpdateAsync(About entity);
    Task RemoveAsync(About entity);
}
