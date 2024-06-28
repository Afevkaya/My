using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.DTOs.Request.Portfolio;
using MyBlog.Core.Services;
using MyBlog.Services.Validations.Portfolio;

namespace MyBlog.UI.Controllers;

public class PortfolioController(IPortfolioService _portfolioService, RequestInsertPortfolioValidator validatorInsert, RequestUpdatePortfolioValidator validatorUpdate) : Controller
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
        ValidationResult results = await validatorInsert.ValidateAsync(request);
        if (results.IsValid)
        {
            await _portfolioService.InsertAsync(request);
            return RedirectToAction("Index");
        }
        foreach (var error in results.Errors)
        {
            ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
        }
        
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update(int Id)
    {
        ViewBag.v1 = "Proje Güncelle";
        ViewBag.v2 = "Proje";
        ViewBag.v3 = "Proje Güncelle";
        var portfolio = await _portfolioService.GetAsync(Id);
        return View(portfolio.Data);
    }
    
    [HttpPost]
    public async Task<IActionResult> Update(RequestUpdatePortfolio request)
    {
        ValidationResult results = await validatorUpdate.ValidateAsync(request);
        if (results.IsValid)
        {
            await _portfolioService.UpdateAsync(request);
            return RedirectToAction("Index");
        }
        foreach (var error in results.Errors)
        {
            ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
        }
        
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> RemoveAsync([FromBody] RequestRemovePortfolio request)
    {
        await _portfolioService.RemoveAsync(request);
        return RedirectToAction("Index");
    }
}