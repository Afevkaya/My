using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class PortfolioRepository: IPortfolioRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public PortfolioRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Portfolio>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Portfolio> GetAsync(int id) => await GetQueryable().AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

    public IQueryable<Portfolio> GetQueryable() => _myBlogDbContext.Porfolios.Where(p => !p.IsDeleted);

    public async Task<Portfolio> InsertAsync(Portfolio entity)
    {
        await _myBlogDbContext.Porfolios.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Portfolio entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Portfolio entity)
    {
        _myBlogDbContext.Porfolios.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
