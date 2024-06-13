using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class ServiceRepository: IServiceRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public ServiceRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Service>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Service> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(se => se.Id == id);

    public IQueryable<Service> GetQueryable() => _myBlogDbContext.Services.Where(se => !se.IsDeleted);

    public async Task<Service> InsertAsync(Service entity)
    {
        await _myBlogDbContext.Services.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Service entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Service entity)
    {
        _myBlogDbContext.Services.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
