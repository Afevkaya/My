using MyBlog.Core.Entities;

namespace MyBlog.Core.Services;

public interface ITestimonialService
{
    Task<ICollection<Testimonial>> GetsAsync();
    Task<Testimonial> GetAsync(int id);
    Task<Testimonial> InsertAsync(Testimonial entity);
    Task UpdateAsync(Testimonial entity);
    Task RemoveAsync(Testimonial entity);
}
