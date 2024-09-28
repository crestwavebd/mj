using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpPost("process")]
    public IActionResult ProcessPayment([FromBody] PaymentRequest request)
    {
        // পেমেন্ট প্রক্রিয়াকরণ লজিক এখানে লিখুন
        return Ok(new { Status = "Payment Processed" });
    }
}

public class PaymentRequest
{
    public string PaymentMethod { get; set; }
    public decimal Amount { get; set; }
}

Step 4: Startup.cs এ Web API রাউটিং কনফিগার করা
1. 
Startup.cs ফাইলে গিয়ে নিচের কোড যোগ করুন:

public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.AddControllers(); // Web API কন্ট্রোলার যোগ করার জন্য
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
        endpoints.MapControllers(); // Web API রাউটিং যোগ করার জন্য
    });
}

