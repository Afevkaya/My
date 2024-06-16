using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Contact;

namespace MyBlog.Core.Services;

public interface IContactService
{
    Task<ApiBaseResponse<List<ResponseContact>>> GetsAsync();
    // Task<ApiBaseResponse<ResponseContact>> GetAsync(int id);
    // Task<ApiBaseResponse<ResponseContact>> InsertAsync(ResponseContact entity);
    // Task UpdateAsync(ResponseContact entity);
    // Task RemoveAsync(ResponseContact entity);
}
