using Microsoft.EntityFrameworkCore;

namespace productsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<product> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(p => p.name) 
                     .HasMaxLength(80);

            modelBuilder.Entity<product>()
                .Property(p => p.price)
                     .HasPrecision(10 ,2);

            modelBuilder.Entity<product>()
                .HasData(
                         new product {id = 1, name = "Caneta", price = 5.99m, Inventory = 5},
                         new product {id = 2, name = "Impressora", price = 1445.99m, Inventory = 2 },
                         new product {id = 3, name = "Papel Sulft", price = 17.99m, Inventory = 2 });
        }
    }
}
