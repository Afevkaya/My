using MyBlog.Core.DTOs.Response.Experience;

namespace MyBlog.Core.Services;

public interface IExperinceService
{
    Task<ICollection<ResponseExperience>> GetsAsync();
    Task<ResponseExperience> GetAsync(int id);
    Task<ResponseExperience> InsertAsync(ResponseExperience entity);
    Task UpdateAsync(ResponseExperience entity);
    Task RemoveAsync(ResponseExperience entity);
}
