using MyBlog.Core.DTOs.Response.Testimonial;

namespace MyBlog.Core.Services;

public interface ITestimonialService
{
    Task<ICollection<ResponseTestimonial>> GetsAsync();
    Task<ResponseTestimonial> GetAsync(int id);
    Task<ResponseTestimonial> InsertAsync(ResponseTestimonial entity);
    Task UpdateAsync(ResponseTestimonial entity);
    Task RemoveAsync(ResponseTestimonial entity);
}
