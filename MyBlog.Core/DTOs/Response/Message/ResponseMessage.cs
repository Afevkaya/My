namespace MyBlog.Core.DTOs.Response.Message;

public class ResponseMessage: BaseResponse
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
