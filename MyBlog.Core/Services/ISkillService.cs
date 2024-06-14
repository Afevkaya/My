using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface ISkillService
{
    Task<ICollection<Skill>> GetsAsync();
    Task<Skill> GetAsync(int id);
    Task<Skill> InsertAsync(Skill entity);
    Task UpdateAsync(Skill entity);
    Task RemoveAsync(Skill entity);
}
