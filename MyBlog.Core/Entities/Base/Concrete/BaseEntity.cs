using System.ComponentModel.DataAnnotations;
using MyBlog.Core.Entities.Base.Abstract;

namespace MyBlog.Core.Entities.Base.Concrete;

public class BaseEntity : IBaseEntity
{
    [Key]
    public int Id { get; set; }
}
