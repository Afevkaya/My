using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class About: ModifiableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Age { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ImageUrl { get; set; }
}
