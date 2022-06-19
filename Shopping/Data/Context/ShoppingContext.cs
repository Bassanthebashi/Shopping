using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopping.Data.Models;

namespace Shopping.Data.Context
{
    public class ShoppingContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            builder.Entity<Product>().HasData(
                new Product { Id=Guid.NewGuid(),Name="Laptop",Description="HP 8Ram SSD", Stock=5, 
                Price=100,Image= "../../../../assets/images/lap.jpg"
            },
                new Product { Id=Guid.NewGuid(),Name="Tablet",Description="Black Dell ", Stock=5, Price = 200 ,Image= "../../../../assets/images/tav.png" },
                new Product { Id=Guid.NewGuid(),Name="Pen",Description="Blue thin font", Stock=5, Price = 20 , Image = "../../../../assets/images/images.png" },
                new Product { Id=Guid.NewGuid(),Name="Bag",Description="Large pink for Books", Stock=5, Price = 300, Image = "../../../../assets/images/bag.png" },
                new Product { Id=Guid.NewGuid(),Name="NoteBook",Description="100 pages", Stock=5, Price = 10, Image = "../../../../assets/images/note.png" },
                new Product { Id=Guid.NewGuid(),Name="cravate",Description="grey for primary school", Stock=5, Price = 50 , Image = "../../../../assets/images/cr.jpg" }
               );
            

            base.OnModelCreating(builder);
        }
    }
}
