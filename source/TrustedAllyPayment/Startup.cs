public void ConfigureServices(IServiceCollection services) {
    services .AddControllersWithViews();
    services .AddControllers();
    // Web API কন্ট্রোলার যোগ করার জন্য
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
    if (env.IsDevelopment())

{
    app .UseDeveloperExceptionPage();
}

else {
    app .UseExceptionHandler("/Home/Error");
    app .UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => {
endpoints.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");
endpoints.MapControllers(); // Web API রাউটিং যোগ করার জন্য
});
}
