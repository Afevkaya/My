using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Testimonial: ModifiableEntity
{
    public string ClientName { get; set; }
    public string Company { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
}
