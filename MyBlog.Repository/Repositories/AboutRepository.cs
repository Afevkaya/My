using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class AboutRepository : IAboutRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public AboutRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<About>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<About> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(ab => ab.Id == id);

    public IQueryable<About> GetQueryable() => _myBlogDbContext.Abouts.Where(ab => !ab.IsDeleted);

    public async Task<About> InsertAsync(About entity)
    {
        await _myBlogDbContext.Abouts.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(About entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(About entity)
    {
        _myBlogDbContext.Abouts.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
