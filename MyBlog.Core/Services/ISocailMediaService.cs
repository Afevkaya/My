using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.SocialMedia;

namespace MyBlog.Core.Services;

public interface ISocailMediaService
{
    Task<ICollection<ApiBaseResponse<ResponseSocialMedia>>> GetsAsync();
    Task<ApiBaseResponse<ResponseSocialMedia>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseSocialMedia>> InsertAsync(ResponseSocialMedia entity);
    Task UpdateAsync(ResponseSocialMedia entity);
    Task RemoveAsync(ResponseSocialMedia entity);
}
