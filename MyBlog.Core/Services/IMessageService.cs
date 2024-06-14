using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IMessageService
{
    Task<ICollection<Message>> GetsAsync();
    Task<Message> GetAsync(int id);
    Task<Message> InsertAsync(Message entity);
    Task UpdateAsync(Message entity);
    Task RemoveAsync(Message entity);
}
