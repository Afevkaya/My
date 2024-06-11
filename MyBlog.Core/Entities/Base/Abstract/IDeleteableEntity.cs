namespace MyBlog.Core.Entities.Base.Abstract;

public interface IDeleteableEntity
{
    bool IsDeleted { get; set; }
}
