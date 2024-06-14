using MyBlog.Core.DTOs.Response.SocialMedia;

namespace MyBlog.Core.Services;

public interface ISocailMediaService
{
    Task<ICollection<ResponseSocialMedia>> GetsAsync();
    Task<ResponseSocialMedia> GetAsync(int id);
    Task<ResponseSocialMedia> InsertAsync(ResponseSocialMedia entity);
    Task UpdateAsync(ResponseSocialMedia entity);
    Task RemoveAsync(ResponseSocialMedia entity);
}
