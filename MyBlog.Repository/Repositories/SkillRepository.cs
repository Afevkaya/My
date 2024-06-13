using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class SkillRepository: ISkillRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public SkillRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Skill>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Skill> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(sk => sk.Id == id);

    public IQueryable<Skill> GetQueryable() => _myBlogDbContext.Skills.Where(sk => !sk.IsDeleted);

    public async Task<Skill> InsertAsync(Skill entity)
    {
        await _myBlogDbContext.Skills.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Skill entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Skill entity)
    {
        _myBlogDbContext.Skills.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
