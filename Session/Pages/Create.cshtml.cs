using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session.Models;

namespace Session.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Login login { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("login", login.UserName); // создание сессионной переменной
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
