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
            Message = "Mật khẩu xác nhận không khớp";
            return;
        }

        
        HttpContext.Session.SetString("FullName", FullName);
        HttpContext.Session.SetString("Email", Email);
        HttpContext.Session.SetString("Password", Password);

        Message = "Đăng ký thành công , bạn có thể đăng nhập";
    }
}