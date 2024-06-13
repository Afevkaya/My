using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface ISocailMediaRepository
{
    IQueryable<SocialMedia> GetQueryable();
    Task<ICollection<SocialMedia>> GetAboutsAsync();
    Task<SocialMedia> GetAsync(int id);
    Task<SocialMedia> InsertAsync(SocialMedia entity);
    Task UpdateAsync(SocialMedia entity);
    Task RemoveAsync(SocialMedia entity);
}
