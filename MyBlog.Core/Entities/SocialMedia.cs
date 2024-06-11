using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class SocialMedia: ModifiableEntity
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public bool IsStatus { get; set; }
}
