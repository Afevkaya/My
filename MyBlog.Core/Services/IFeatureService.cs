using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Feature;

namespace MyBlog.Core.Services;

public interface IFeatureService
{
    Task<ICollection<ApiBaseResponse<ResponseFeature>>> GetsAsync();
    Task<ApiBaseResponse<ResponseFeature>> GetAsync(int id);
    Task<ResponseFeature> InsertAsync(ResponseFeature entity);
    Task UpdateAsync(ResponseFeature entity);
    Task RemoveAsync(ResponseFeature entity);
}
