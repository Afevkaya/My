using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents.Feature;

public class FeatureListViewComponent: ViewComponent
{
    private readonly IFeatureService _featureService;

    public FeatureListViewComponent(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var features = await _featureService.GetsAsync();
        return View(features.Data);
    }
}
