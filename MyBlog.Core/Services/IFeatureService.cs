using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IFeatureService
{
    Task<ICollection<Feature>> GetsAsync();
    Task<Feature> GetAsync(int id);
    Task<Feature> InsertAsync(Feature entity);
    Task UpdateAsync(Feature entity);
    Task RemoveAsync(Feature entity);
}
