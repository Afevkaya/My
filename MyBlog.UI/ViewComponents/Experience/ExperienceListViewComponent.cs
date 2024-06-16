using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class ExperienceListViewComponent: ViewComponent
{
    private readonly IExperinceService _experinceService;

    public ExperienceListViewComponent(IExperinceService experinceService)
    {
        _experinceService = experinceService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var experiences = await _experinceService.GetsAsync();
        return View(experiences.Data);
    }
}
