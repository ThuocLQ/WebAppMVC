var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

/*app.MapControllerRoute(
        name: "product-details",
        pattern: "p/{id}",
        defaults: new {controller = "Product", action = "Details"})
       .WithStaticAssets();
app.MapControllerRoute(
        name: "collection",
        pattern: "c/{id=1}",
        defaults: new {controller = "Collection", action = "Index"})
    .WithStaticAssets();*/

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Privacy}/{id?}")
    .WithStaticAssets();


app.Run();