using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.Controllers;

public class AdminController : Controller
{
    
    public PartialViewResult PartialSideBar()
    {
        return PartialView();
    }
}