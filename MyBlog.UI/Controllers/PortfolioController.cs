using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.DTOs.Request.Portfolio;
using MyBlog.Core.Services;

namespace MyBlog.UI.Controllers;

public class PortfolioController(IPortfolioService _portfolioService) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Proje Listesi";
        ViewBag.v2 = "Projeler";
        ViewBag.v3 = "Proje Listesi";
        var portfolios = await _portfolioService.GetsAsync();
        return View(portfolios.Data);
    }

    [HttpGet]
    public async Task<IActionResult> Insert()
    {
        ViewBag.v1 = "Proje Ekle";
        ViewBag.v2 = "Proje";
        ViewBag.v3 = "Proje Ekle";
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Insert(RequestInsertPortfolio request)
    {
        await _portfolioService.InsertAsync(request);
        return RedirectToAction("Index");
    }
}