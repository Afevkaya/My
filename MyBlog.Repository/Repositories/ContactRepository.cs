using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public ContactRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Contact>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Contact> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(c => c.Id == id);

    public IQueryable<Contact> GetQueryable() => _myBlogDbContext.Contacts.Where(c => !c.IsDeleted);

    public async Task<Contact> InsertAsync(Contact entity)
    {
        await _myBlogDbContext.Contacts.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Contact entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Contact entity)
    {
        _myBlogDbContext.Contacts.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
