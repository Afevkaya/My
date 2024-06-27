using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyBlog.Core.Entities;

namespace MyBlog.Repositories;

public class MyBlogDbContext : DbContext
{
    public MyBlogDbContext(DbContextOptions<MyBlogDbContext> options): base(options)
    {
        
    }
    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfolio> Porfolios { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyBlogDbContext>
{
    public MyBlogDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<MyBlogDbContext>();
        var connectionString = "Server=localhost;Database=MyBlogDb;User ID=SA;Password=Muhammet.evkaya.1;Trusted_Connection=False;Encrypt=False;";
        builder.UseSqlServer(connectionString);
        return new MyBlogDbContext(builder.Options);
    }
}