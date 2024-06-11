using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Experience: ModifiableEntity
{
    public string Name { get; set; }
    public string Date { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }

}
