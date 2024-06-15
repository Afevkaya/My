using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class ServiceListViewComponent: ViewComponent
{
    private readonly IServiceService _serviceService;

    public ServiceListViewComponent(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = await _serviceService.GetsAsync();
        return View(services.Data);
    }
}
