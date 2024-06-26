using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class ExperienceListViewComponent: ViewComponent
{
    private readonly IExperienceService _experienceService;

    public ExperienceListViewComponent(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var experiences = await _experienceService.GetsAsync();
        return View(experiences.Data);
    }
}
