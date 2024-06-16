using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents;

public class TestimonialListViewComponent: ViewComponent
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialListViewComponent(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var testimonials = await _testimonialService.GetsAsync();
        return View(testimonials.Data);
    }
}
