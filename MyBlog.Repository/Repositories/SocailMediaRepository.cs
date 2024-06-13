using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class SocailMediaRepository: ISocailMediaRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public SocailMediaRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<SocialMedia>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<SocialMedia> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(sm => sm.Id == id);

    public IQueryable<SocialMedia> GetQueryable() => _myBlogDbContext.SocialMedias.Where(sm => !sm.IsDeleted);

    public async Task<SocialMedia> InsertAsync(SocialMedia entity)
    {
        await _myBlogDbContext.SocialMedias.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(SocialMedia entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(SocialMedia entity)
    {
        _myBlogDbContext.SocialMedias.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
