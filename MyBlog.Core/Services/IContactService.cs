using MyBlog.Core.DTOs.Response.Contact;

namespace MyBlog.Core.Services;

public interface IContactService
{
    Task<ICollection<ResponseContact>> GetsAsync();
    Task<ResponseContact> GetAsync(int id);
    Task<ResponseContact> InsertAsync(ResponseContact entity);
    Task UpdateAsync(ResponseContact entity);
    Task RemoveAsync(ResponseContact entity);
}
