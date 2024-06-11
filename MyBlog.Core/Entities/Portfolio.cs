using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Portfolio: ModifiableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
