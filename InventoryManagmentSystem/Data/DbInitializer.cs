using System;
using System.Linq;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Ensure database is created and migrations are applied
            context.Database.Migrate();

            // Seed Users if empty
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Username = "admin", Password = "admin", Role = "Admin" },
                    new User { Username = "staff", Password = "staff", Role = "Staff" }
                );
                context.SaveChanges();
            }

            // Seed some default products if empty so the app has demo data
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Laptop", Category = "Electronics", Quantity = 10, Price = 15000m, Supplier = "Dell" },
                    new Product { Name = "Mouse", Category = "Electronics", Quantity = 3, Price = 500m, Supplier = "Logitech" }, // low stock
                    new Product { Name = "Keyboard", Category = "Electronics", Quantity = 12, Price = 1200m, Supplier = "HP" },
                    new Product { Name = "Monitor", Category = "Electronics", Quantity = 4, Price = 8000m, Supplier = "Samsung" } // low stock
                );
                context.SaveChanges();
            }
        }
    }
}
