using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface IMessageRepository
{
    IQueryable<Message> GetQueryable();
    Task<ICollection<Message>> GetsAsync();
    Task<Message> GetAsync(int id);
    Task<Message> InsertAsync(Message entity);
    Task UpdateAsync(Message entity);
    Task RemoveAsync(Message entity);
}
