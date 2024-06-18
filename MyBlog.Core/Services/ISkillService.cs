using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Skill;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Skill;

namespace MyBlog.Core.Services;

public interface ISkillService
{
    Task<ApiBaseResponse<List<ResponseSkill>>> GetsAsync();
    Task<ApiBaseResponse<ResponseSkill>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseSkill>> InsertAsync(RequestInsertSkill request);
    Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(RequestUpdateSkill request);
    Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(RequestRemoveSkill request);
}
