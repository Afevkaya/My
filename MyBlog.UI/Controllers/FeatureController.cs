using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.Controllers;

public class FeatureController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
