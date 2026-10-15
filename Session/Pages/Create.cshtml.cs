using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session.Models;

namespace Session.Pages;

public class CreateModel : PageModel
{
    [BindProperty]
    public Login LoginModel { get; set; } = default!;

    public IActionResult OnGet() => Page();

    public IActionResult OnPost()
    {
        if (ModelState.IsValid && LoginModel.UserName != null)
        {
            HttpContext.Session.SetString("login", LoginModel.UserName); // створення сесійної змінної
            return RedirectToPage("Index");
        }
        return Page();
    }
}