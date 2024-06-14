namespace MyBlog.Core.DTOs.Response.About;

public class ResponseAbout: BaseResponse
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Age { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string ImageUrl { get; set; }
}
