using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface IContactService
{
    Task<ICollection<Contact>> GetsAsync();
    Task<Contact> GetAsync(int id);
    Task<Contact> InsertAsync(Contact entity);
    Task UpdateAsync(Contact entity);
    Task RemoveAsync(Contact entity);
}
