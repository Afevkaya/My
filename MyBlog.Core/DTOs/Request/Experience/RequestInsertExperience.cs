namespace MyBlog.Core.DTOs.Request.Experience;

public class RequestInsertExperience
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}