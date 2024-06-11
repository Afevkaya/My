using MyBlog.Core.Entities.Base.Concrete;

namespace MyBlog.Core.Entities;

public class Feature: ModifiableEntity
{
    public string Header { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    
}
