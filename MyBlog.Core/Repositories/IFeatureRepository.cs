using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface IFeatureRepository
{
    IQueryable<Feature> GetQueryable();
    Task<ICollection<Feature>> GetAboutsAsync();
    Task<Feature> GetAsync(int id);
    Task<Feature> InsertAsync(Feature entity);
    Task UpdateAsync(Feature entity);
    Task RemoveAsync(Feature entity);
}
