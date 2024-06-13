using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface IServiceRepository
{
    IQueryable<Service> GetQueryable();
    Task<ICollection<Service>> GetAboutsAsync();
    Task<Service> GetAsync(int id);
    Task<Service> InsertAsync(Service entity);
    Task UpdateAsync(Service entity);
    Task RemoveAsync(Service entity);
}
