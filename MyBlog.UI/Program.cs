using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.DTOs.Request.Portfolio;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Repositories;
using MyBlog.Services;
using MyBlog.Services.Validations.Portfolio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddValidatorsFromAssemblyContaining<RequestInsertPortfolioValidator>();

builder.Services.AddDbContext<MyBlogDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnection"));
});

builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IAboutRepository, AboutRepository>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IPortfolioRepository, PortfolioRepository>();
builder.Services.AddScoped<IPortfolioService, PortfolioService>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<IExperienceService, ExperienceService>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IMessageService, MessageService>();

builder.Services.AddAutoMapper(typeof(MapProfile));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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