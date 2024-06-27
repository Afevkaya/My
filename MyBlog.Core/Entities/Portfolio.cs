using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Portfolio: ModifiableEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string ImageUrl2 { get; set; }
    public string? ProjectUrl { get; set; }
    public string? Platform { get; set; }
    public string Price { get; set; }
    public bool? Status { get; set; }
    public int Value { get; set; }
    public string? Image1 { get; set; }
    public string? Image2 { get; set; }
    public string? Image3 { get; set; }
    public string? Image4 { get; set; }
}
