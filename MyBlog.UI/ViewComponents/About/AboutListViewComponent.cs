using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class AboutListViewComponent: ViewComponent
{
    private readonly IAboutService _aboutService;

    public AboutListViewComponent(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var abouts = await _aboutService.GetsAsync();
        return View(abouts.Data);
    }
}
