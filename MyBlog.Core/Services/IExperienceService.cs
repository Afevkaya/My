using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Request.Experience;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Experience;

namespace MyBlog.Core.Services;

public interface IExperienceService
{
    Task<ApiBaseResponse<List<ResponseExperience>>> GetsAsync();
    Task<ApiBaseResponse<ResponseExperience>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseExperience>> InsertAsync(RequestInsertExperience request);
    Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(RequestUpdateExperience request);
    Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(RequestRemoveExperience request);
}
