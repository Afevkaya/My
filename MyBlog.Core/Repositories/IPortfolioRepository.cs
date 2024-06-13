using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface IPortfolioRepository
{
    IQueryable<Portfolio> GetQueryable();
    Task<ICollection<Portfolio>> GetsAsync();
    Task<Portfolio> GetAsync(int id);
    Task<Portfolio> InsertAsync(Portfolio entity);
    Task UpdateAsync(Portfolio entity);
    Task RemoveAsync(Portfolio entity);
}
