using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Message: ModifiableEntity
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
