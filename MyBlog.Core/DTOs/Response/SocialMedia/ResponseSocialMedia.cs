namespace MyBlog.Core.DTOs.Response.SocialMedia;

public class ResponseSocialMedia: BaseResponse
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public bool IsStatus { get; set; }
}
