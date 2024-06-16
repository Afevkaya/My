using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;

namespace MyBlog.UI.ViewComponents.Contact;

public class ContactDetailsViewComponent: ViewComponent
{
    private readonly IContactService _contactService;

    public ContactDetailsViewComponent(IContactService contactService)
    {
        _contactService = contactService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contacts = await _contactService.GetsAsync();
        return View(contacts.Data);
    }
}
