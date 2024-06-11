using MyBlog.Core.Entities.Base.Abstract;

namespace MyBlog.Core.Entities.Base.Concrete;

public class BaseEntity : IBaseEntity
{
    public int Id { get; set; }
}
