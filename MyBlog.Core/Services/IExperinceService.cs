using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Experience;

namespace MyBlog.Core.Services;

public interface IExperinceService
{
    Task<ApiBaseResponse<List<ResponseExperience>>> GetsAsync();
    // Task<ApiBaseResponse<ResponseExperience>> GetAsync(int id);
    // Task<ApiBaseResponse<ResponseExperience>> InsertAsync(ResponseExperience entity);
    // Task UpdateAsync(ResponseExperience entity);
    // Task RemoveAsync(ResponseExperience entity);
}
