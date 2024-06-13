using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface IAboutRepository
{
    IQueryable<About> GetQueryable();
    Task<ICollection<About>> GetsAsync();
    Task<About> GetAsync(int id);
    Task<About> InsertAsync(About entity);
    Task UpdateAsync(About entity);
    Task RemoveAsync(About entity);
}
