using Microsoft.AspNetCore.Mvc;

namespace MyBlog.UI.ViewComponents.Contact;

public class SendMessageViewComponent: ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
