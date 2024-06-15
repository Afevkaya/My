using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response;
using MyBlog.Core.DTOs.Response.Feature;

namespace MyBlog.Core.Services;

public interface IFeatureService
{
    Task<ApiBaseResponse<List<ResponseFeature>>> GetsAsync();
    Task<ApiBaseResponse<ResponseFeature>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseFeature>> InsertAsync(ResponseFeature request);
    Task<ApiBaseResponse<ResponseNoContent>> UpdateAsync(ResponseFeature request);
    Task<ApiBaseResponse<ResponseNoContent>> RemoveAsync(ResponseFeature request);
}
