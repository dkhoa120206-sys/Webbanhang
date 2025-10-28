using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Password { get; set; }

    public string Message { get; set; }

    public void OnPost()
    {
        var savedEmail = HttpContext.Session.GetString("Email");
        var savedPassword = HttpContext.Session.GetString("Password");

        if (Email == savedEmail && Password == savedPassword)
        {
            Message = "Đăng nhập thành công! Xin chào " + HttpContext.Session.GetString("FullName");
        }
        else
        {
            Message = "Email hoặc mật khẩu không đúng!";
        }
    }
}