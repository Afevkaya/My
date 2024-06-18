using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.DTOs.Request.Skill;
using MyBlog.Core.Services;

namespace MyBlog.UI.Controllers;

public class SkillController : Controller
{
    private readonly ISkillService _skillService;

    public SkillController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public async Task<IActionResult> Index()
    {
        var skills = await _skillService.GetsAsync();
        return View(skills.Data);
    }

    public async Task<IActionResult> Insert()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Insert(RequestInsertSkill request)
    {
        await _skillService.InsertAsync(request);
        return RedirectToAction("Index");
    }
}