using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IServiceService
{
    Task<ICollection<Service>> GetsAsync();
    Task<Service> GetAsync(int id);
    Task<Service> InsertAsync(Service entity);
    Task UpdateAsync(Service entity);
    Task RemoveAsync(Service entity);
}
