using MyBlog.Core.DTOs.Response.Message;

namespace MyBlog.Core.Services;

public interface IMessageService
{
    Task<ICollection<ResponseMessage>> GetsAsync();
    Task<ResponseMessage> GetAsync(int id);
    Task<ResponseMessage> InsertAsync(ResponseMessage entity);
    Task UpdateAsync(ResponseMessage entity);
    Task RemoveAsync(ResponseMessage entity);
}
