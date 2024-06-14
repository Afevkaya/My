using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Portfolio: ModifiableEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
