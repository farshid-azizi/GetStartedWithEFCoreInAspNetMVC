using GetStartedWithEFCoreInAspNetMVC.Models.CustomerAggregate;
using GetStartedWithEFCoreInAspNetMVC.Models.OrderAggregate;
using GetStartedWithEFCoreInAspNetMVC.Models.ProductAggregate;
using Microsoft.EntityFrameworkCore;

namespace GetStartedWithEFCoreInAspNetMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Order>().OwnsOne(c => c.Address);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
