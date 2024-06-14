namespace MyBlog.Core.DTOs.Response.Contact;

public class ResponseContact: BaseResponse
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
}
