using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.Controllers;

public class AdminController : Controller
{
    public PartialViewResult PartialSideBar()
    {
        return PartialView();
    }

    public PartialViewResult PartialFooter()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialNavBar()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialHead()
    {
        return PartialView();
    }
    
    public PartialViewResult PartialScript()
    {
        return PartialView();
    }
}