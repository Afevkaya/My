using MyBlog.Core.Entities.Base.Abstract;

namespace MyBlog.Core.Entities.Base.Concrete;

public class ModifiableEntity: BaseEntity, IModifiableEntity
{
    public virtual DateTime CreatedOn { get; set; }
    public virtual int CreatedBy { get; set; }
    public virtual DateTime? UpdatedOn { get; set; }
    public virtual int? UpdatedBy { get; set; }
    public virtual bool IsDeleted { get; set; }
}
