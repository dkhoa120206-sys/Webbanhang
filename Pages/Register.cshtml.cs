using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public string FullName { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Password { get; set; }
    [BindProperty]
    public string ConfirmPassword { get; set; }

    public string Message { get; set; }

    public void OnPost()
    {
        if (Password != ConfirmPassword)
        {
            Message = "M?t kh?u x�c nh?n kh�ng kh?p!";
            return;
        }

        // T?m th?i l?u th�ng tin ng??i d�ng trong Session
        HttpContext.Session.SetString("FullName", FullName);
        HttpContext.Session.SetString("Email", Email);
        HttpContext.Session.SetString("Password", Password);

        Message = "??ng k� th�nh c�ng! B?n c� th? ??ng nh?p.";
    }
}