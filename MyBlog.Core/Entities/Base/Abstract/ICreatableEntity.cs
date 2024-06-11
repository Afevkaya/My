namespace MyBlog.Core.Entities.Base.Abstract;

public interface ICreatableEntity
{
    DateTime CreatedOn { get; set; }
    int CreatedBy { get; set; }
}
