using Microsoft.EntityFrameworkCore;

namespace PF.Web.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<ShoeColorVariation> ShoeColorVariations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        // Constructor that takes DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Optional: only keep OnConfiguring if you want a fallback
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=shoeinventory.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Shoes
            modelBuilder.Entity<Shoe>().HasData(
                new Shoe { Id = 1, Name = "AirMax", Brand = "Nike", Price = 4500 },
                new Shoe { Id = 2, Name = "UltraBoost", Brand = "Adidas", Price = 5500 }
            );

            // Seed ShoeColorVariations
            modelBuilder.Entity<ShoeColorVariation>().HasData(
                new ShoeColorVariation { Id = 1, ShoeId = 1, Color = "Red", Stock = 10 },
                new ShoeColorVariation { Id = 2, ShoeId = 1, Color = "Black", Stock = 8 },
                new ShoeColorVariation { Id = 3, ShoeId = 2, Color = "White", Stock = 5 },
                new ShoeColorVariation { Id = 4, ShoeId = 2, Color = "Black", Stock = 7 }
            );

            // Seed Suppliers
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Shoe Supplier Inc.", ContactInfo = "09123456789" },
                new Supplier { Id = 2, Name = "Footwear Traders", ContactInfo = "09987654321" }
            );
        }
    }
}
