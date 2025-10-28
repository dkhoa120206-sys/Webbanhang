namespace Webapplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Cấu hình các dịch vụ
            builder.Services.AddRazorPages();
            builder.Services.AddSession(); // thêm dòng này

            var app = builder.Build();

            // Cấu hình pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession(); // thêm dòng này

            app.MapRazorPages();

            app.Run();


        }
    }
}
