using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Contact: ModifiableEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
}
