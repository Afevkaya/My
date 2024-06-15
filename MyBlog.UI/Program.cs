using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Repositories;
using MyBlog.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyBlogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnection"));
});

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();

builder.Services.AddAutoMapper(typeof(MapProfile));

var app = builder.Build();

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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
