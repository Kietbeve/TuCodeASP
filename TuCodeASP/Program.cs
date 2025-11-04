using TuCodeASP.Middlewares;
using TuCodeASP.Domain.Abstract;//Dung interface
using TuCodeASP.FakeRepository;//dung FakeRepo

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dang Ki DI
builder.Services.AddSingleton<IProductRepository,FakeProductRepository>();//doc repo 1 lan suot chuong trinh

var app = builder.Build();

//Dang ki MW
app.UseMiddleware<RequestLogger>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
