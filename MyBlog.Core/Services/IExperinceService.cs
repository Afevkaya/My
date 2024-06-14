using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IExperinceService
{
    Task<ICollection<Experience>> GetsAsync();
    Task<Experience> GetAsync(int id);
    Task<Experience> InsertAsync(Experience entity);
    Task UpdateAsync(Experience entity);
    Task RemoveAsync(Experience entity);
}
