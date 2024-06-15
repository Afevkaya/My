using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class SkillListViewComponent: ViewComponent
{
    private readonly ISkillService _skillService;

    public SkillListViewComponent(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var skills = await _skillService.GetsAsync();
        return View(skills.Data);
    }
}
