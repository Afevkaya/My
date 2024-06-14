using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface ISocailMediaService
{
    Task<ICollection<SocialMedia>> GetsAsync();
    Task<SocialMedia> GetAsync(int id);
    Task<SocialMedia> InsertAsync(SocialMedia entity);
    Task UpdateAsync(SocialMedia entity);
    Task RemoveAsync(SocialMedia entity);
}
