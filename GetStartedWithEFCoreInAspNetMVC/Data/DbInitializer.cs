using GetStartedWithEFCoreInAspNetMVC.Models.CustomerAggregate;
using GetStartedWithEFCoreInAspNetMVC.Models.OrderAggregate;
using GetStartedWithEFCoreInAspNetMVC.Models.ProductAggregate;
using Microsoft.EntityFrameworkCore;

namespace GetStartedWithEFCoreInAspNetMVC.Data
{
    public class DbInitializer
    {

        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Customer>().HasData(
                   new Customer { CustomerID = 25, Name = "farshid", Family = "azizi", DateOfBirth = DateTime.Parse("2002-09-01") },
                   new Customer { CustomerID = 50, Name = "reza", Family = "amiri", DateOfBirth = DateTime.Parse("2009-11-12") },
                   new Customer { CustomerID = 75, Name = "amir", Family = "naseri", DateOfBirth = DateTime.Parse("1983-09-24") },
                   new Customer { CustomerID = 100, Name = "shirin", Family = "emadi", DateOfBirth = DateTime.Parse("2000-06-01") },
                   new Customer { CustomerID = 125, Name = "maryam", Family = "tehrani", DateOfBirth = DateTime.Parse("2005-09-01") }
            );
            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductID = 10, Name = "productA", Description = "", Price = 1000 },
                    new Product { ProductID = 20, Name = "productB", Description = "", Price = 36000 },
                    new Product { ProductID = 30, Name = "productC", Description = "", Price = 65200 },
                    new Product { ProductID = 40, Name = "productD", Description = "", Price = 1500 },
                    new Product { ProductID = 50, Name = "productE", Description = "", Price = 14000 },
                    new Product { ProductID = 60, Name = "productF", Description = "", Price = 63520 },
                    new Product { ProductID = 100, Name = "productG", Description = "", Price = 500 }
           );
            modelBuilder.Entity<Order>().HasData(
                 new Order { OrderID = 1, OrderDate = DateTime.Parse("2022-08-07"), CustomerID = 25, OrderState = OrderState.A, },
                new Order { OrderID = 2, OrderDate = DateTime.Parse("2022-06-07"), CustomerID = 50, OrderState = OrderState.A, }
           );
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { OrderItemID = 1, OrderId = 1, ProductID = 10, Price = 1000, Count = 1 },
                 new OrderItem { OrderItemID = 2, OrderId = 1, ProductID = 60, Price = 63520, Count = 2 },
                new OrderItem { OrderItemID = 3, OrderId = 2, ProductID = 100, Price = 490, Count = 10 }
          );
        }
    }
}
