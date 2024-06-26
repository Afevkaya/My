using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class ExperienceRepository: IExperienceRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public ExperienceRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Experience>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Experience> GetAsync(int id) => await GetQueryable().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);

    public IQueryable<Experience> GetQueryable() => _myBlogDbContext.Experiences.Where(e => !e.IsDeleted);

    public async Task<Experience> InsertAsync(Experience entity)
    {
        await _myBlogDbContext.Experiences.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Experience entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Experience entity)
    {
        _myBlogDbContext.Experiences.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
