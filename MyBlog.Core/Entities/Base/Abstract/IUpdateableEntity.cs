namespace MyBlog.Core.Entities.Base.Abstract;

public interface IUpdateableEntity
{
    DateTime? UpdatedOn { get; set; }
    int? UpdatedBy { get; set; }
}
