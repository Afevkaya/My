using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.ViewComponents.Feature;

public class FeatureListViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
