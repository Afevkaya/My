using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class PortfolioListViewComponent: ViewComponent
{
    private readonly IPortfolioService _portfolioService;

    public PortfolioListViewComponent(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var portfolio = await _portfolioService.GetsAsync();
        return View(portfolio.Data);
    }
}
