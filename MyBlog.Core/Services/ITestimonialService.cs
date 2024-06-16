using MyBlog.Core.DTOs;
using MyBlog.Core.DTOs.Response.Testimonial;

namespace MyBlog.Core.Services;

public interface ITestimonialService
{
    Task<ApiBaseResponse<List<ResponseTestimonial>>> GetsAsync();
    // Task<ApiBaseResponse<ResponseTestimonial>> GetAsync(int id);
    // Task<ApiBaseResponse<ResponseTestimonial>> InsertAsync(ResponseTestimonial entity);
    // Task UpdateAsync(ResponseTestimonial entity);
    // Task RemoveAsync(ResponseTestimonial entity);
}
