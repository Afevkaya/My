using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface ISkillRepository
{
    IQueryable<Skill> GetQueryable();
    Task<ICollection<Skill>> GetsAsync();
    Task<Skill> GetAsync(int id);
    Task<Skill> InsertAsync(Skill entity);
    Task UpdateAsync(Skill entity);
    Task RemoveAsync(Skill entity);
}
