using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class FeatureRepository: IFeatureRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public FeatureRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Feature>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Feature> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(f =>f.Id == id);

    public IQueryable<Feature> GetQueryable() => _myBlogDbContext.Features.Where(f => !f.IsDeleted);

    public async Task<Feature> InsertAsync(Feature entity)
    {
        await _myBlogDbContext.Features.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Feature entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Feature entity)
    {
        _myBlogDbContext.Features.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
