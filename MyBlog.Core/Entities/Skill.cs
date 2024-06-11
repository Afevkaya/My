using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Skill: ModifiableEntity
{
    public string Title { get; set; }
    public string Value { get; set; }
}
