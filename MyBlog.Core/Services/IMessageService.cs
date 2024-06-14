using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Message;

namespace MyBlog.Core.Services;

public interface IMessageService
{
    Task<ICollection<ApiBaseResponse<ResponseMessage>>> GetsAsync();
    Task<ApiBaseResponse<ResponseMessage>> GetAsync(int id);
    Task<ApiBaseResponse<ResponseMessage>> InsertAsync(ResponseMessage entity);
    Task UpdateAsync(ResponseMessage entity);
    Task RemoveAsync(ResponseMessage entity);
}
