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

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Yetenek Listesi";
        ViewBag.v2 = "Yetenekler";
        ViewBag.v3 = "Yetenek Listesi";
        var skills = await _skillService.GetsAsync();
        return View(skills.Data);
    }

    [HttpGet]
    public async Task<IActionResult> Insert()
    {
        ViewBag.v1 = "Yetenek Ekleme";
        ViewBag.v2 = "Yetenekler";
        ViewBag.v3 = "Yetenek Ekleme";
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Insert(RequestInsertSkill request)
    {
        await _skillService.InsertAsync(request);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Update(int Id)
    {
        ViewBag.v1 = "Yetenek Düzenleme";
        ViewBag.v2 = "Yetenekler";
        ViewBag.v3 = "Yetenek Düzenleme";
        var response = await _skillService.GetAsync(Id);
        return View(response.Data);
    }
    
    [HttpPost]
    public async Task<IActionResult> Update(RequestUpdateSkill request)
    {
        await _skillService.UpdateAsync(request);
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public async Task<IActionResult> Remove([FromBody] RequestRemoveSkill request)
    {
        await _skillService.RemoveAsync(request);
        return RedirectToAction("Index");
    }
}