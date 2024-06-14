namespace MyBlog.Core.DTOs.Response.Testimonial;

public class ResponseTestimonial: BaseResponse
{
    public string ClientName { get; set; }
    public string Company { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
}
