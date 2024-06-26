using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.DTOs.Request.Experience;
using MyBlog.Core.Services;

namespace MyBlog.UI.Controllers;

public class ExperienceController : Controller
{
    private readonly IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Deneyim Listesi";
        ViewBag.v2 = "Deneyimler";
        ViewBag.v3 = "Deneyim Listesi";
        var experiences = await _experienceService.GetsAsync();
        return View(experiences.Data);
    }

    [HttpGet]
    public async Task<IActionResult> Insert()
    {
        ViewBag.v1 = "Deneyim Ekleme";
        ViewBag.v2 = "Deneyimler";
        ViewBag.v3 = "Deneyim Ekleme";
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Insert(RequestInsertExperience request)
    {
        await _experienceService.InsertAsync(request);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        ViewBag.v1 = "Deneyim Düzenleme";
        ViewBag.v2 = "Deneyimler";
        ViewBag.v3 = "Deneyim Düzenleme";
        var response = await _experienceService.GetAsync(id);
        return View(response.Data);
    }

    [HttpPost]
    public async Task<IActionResult> Update(RequestUpdateExperience request)
    {
        await _experienceService.UpdateAsync(request);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Remove([FromBody]RequestRemoveExperience request)
    {
        await _experienceService.RemoveAsync(request);
        return RedirectToAction("Index");
    }
}