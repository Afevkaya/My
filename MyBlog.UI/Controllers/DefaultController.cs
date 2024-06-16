using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.DTOs.Request;
using MyBlog.Core.Services;

namespace MyBlog.UI.Controllers;


public class DefaultController : Controller
{
    private readonly IMessageService _messageService;

    public DefaultController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public PartialViewResult HeaderPartial()
    {
        return PartialView();
    }

    public PartialViewResult NavbarPartial()
    {
        return PartialView();
    }

    [HttpGet]
    public PartialViewResult SendMessagePartial()
    {
        return PartialView();
    }

    [HttpPost]
    public async Task<PartialViewResult> SendMessagePartial(RequestInsertMessage request)
    {
        await _messageService.InsertAsync(request);
        return PartialView();
    } 
}
