using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.Controllers;


public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public PartialViewResult HeaderPartial()
    {
        return PartialView();
    }
}
