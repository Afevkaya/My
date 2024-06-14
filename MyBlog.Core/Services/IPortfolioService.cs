using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IPortfolioService
{
    Task<ICollection<Portfolio>> GetsAsync();
    Task<Portfolio> GetAsync(int id);
    Task<Portfolio> InsertAsync(Portfolio entity);
    Task UpdateAsync(Portfolio entity);
    Task RemoveAsync(Portfolio entity);
}
