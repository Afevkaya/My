using MyBlog.Core.DTOs.Response.Feature;

namespace MyBlog.Core.Services;

public interface IFeatureService
{
    Task<ICollection<ResponseFeature>> GetsAsync();
    Task<ResponseFeature> GetAsync(int id);
    Task<ResponseFeature> InsertAsync(ResponseFeature entity);
    Task UpdateAsync(ResponseFeature entity);
    Task RemoveAsync(ResponseFeature entity);
}
