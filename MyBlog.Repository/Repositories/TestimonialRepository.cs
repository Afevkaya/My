using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;

namespace MyBlog.Repositories;

public class TestimonialRepository: ITestimonialRepository
{
    private readonly MyBlogDbContext _myBlogDbContext;

    public TestimonialRepository(MyBlogDbContext myBlogDbContext)
    {
        _myBlogDbContext = myBlogDbContext;
    }

    public async Task<ICollection<Testimonial>> GetsAsync() => await GetQueryable().ToListAsync();

    public async Task<Testimonial> GetAsync(int id) => await GetQueryable().FirstOrDefaultAsync(te => te.Id == id);

    public IQueryable<Testimonial> GetQueryable() => _myBlogDbContext.Testimonials.Where(te => !te.IsDeleted);

    public async Task<Testimonial> InsertAsync(Testimonial entity)
    {
        await _myBlogDbContext.Testimonials.AddAsync(entity);
        await _myBlogDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task RemoveAsync(Testimonial entity)
    {
        entity.IsDeleted = true;
        await UpdateAsync(entity);
    }

    public async Task UpdateAsync(Testimonial entity)
    {
        _myBlogDbContext.Testimonials.Update(entity);
        await _myBlogDbContext.SaveChangesAsync();
    }
}
