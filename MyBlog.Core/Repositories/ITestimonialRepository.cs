using MyBlog.Core.Entities;

namespace MyBlog.Core.Repositories;

public interface ITestimonialRepository
{
    IQueryable<Testimonial> GetQueryable();
    Task<ICollection<Testimonial>> GetsAsync();
    Task<Testimonial> GetAsync(int id);
    Task<Testimonial> InsertAsync(Testimonial entity);
    Task UpdateAsync(Testimonial entity);
    Task RemoveAsync(Testimonial entity);
}
