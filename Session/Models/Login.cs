using System.ComponentModel.DataAnnotations;

namespace Session.Models;

public class Login
{
    [Required(ErrorMessage = "Поле має бути заповнене")]
    [Display(Name = "Ім'я користувача: ")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Поле має бути заповнене")]
    [Display(Name = "Пароль: ")]
    public string? Password { get; set; }
}