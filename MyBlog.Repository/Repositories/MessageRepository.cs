using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class MessageRepository: IMessageRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public MessageRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Message>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Message> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(m => m.Id == id);

    public IQueryable<Message> GetQueryable() => _myBlogDbContext.Messages.Where(m => !m.IsDeleted);

    public async Task<Message> InsertAsync(Message entity)
    {
        await _myBlogDbContext.Messages.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Message entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Message entity)
    {
        _myBlogDbContext.Messages.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
