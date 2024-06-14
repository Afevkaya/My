namespace MyBlog.Core.DTOs.Response;

public class BaseResponse
{
     public int Id { get; set; }
    public virtual DateTime CreatedOn { get; set; }
    public virtual int CreatedBy { get; set; }
    public virtual DateTime? UpdatedOn { get; set; }
    public virtual int? UpdatedBy { get; set; }
    public virtual bool IsDeleted { get; set; }
}
