using MyBlog.Core.DTOs.Response.Skill;

namespace MyBlog.Core.Services;

public interface ISkillService
{
    Task<ICollection<ResponseSkill>> GetsAsync();
    Task<ResponseSkill> GetAsync(int id);
    Task<ResponseSkill> InsertAsync(ResponseSkill entity);
    Task UpdateAsync(ResponseSkill entity);
    Task RemoveAsync(ResponseSkill entity);
}
