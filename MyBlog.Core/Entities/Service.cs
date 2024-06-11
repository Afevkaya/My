using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Service: ModifiableEntity
{
    public string Title { get; set; }
    public string ImageUrl { get; set; }
}
