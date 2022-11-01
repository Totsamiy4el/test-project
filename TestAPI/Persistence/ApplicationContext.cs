using Microsoft.EntityFrameworkCore;
using TestAPI.Infrastructure.DbModels;

namespace TestAPI.Infrastructure;

public class ApplicationContext : DbContext
{
    public DbSet<Products> Products { get; set; }
    public DbSet<ProductType> ProductType { get; set; }
    public DbSet<ProductProvider> ProductProvider { get; set; }
    public DbSet<ProductUser> ProductUser { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Provider> Provider { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}


