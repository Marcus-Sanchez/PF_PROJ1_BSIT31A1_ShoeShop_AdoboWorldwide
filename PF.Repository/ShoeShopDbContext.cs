using Microsoft.EntityFrameworkCore;
using PF.Repository.Models;

public class ShoeShopDbContext : DbContext
{
    public ShoeShopDbContext(DbContextOptions<ShoeShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<ShoeColorVariation> ShoeColorVariations { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    public DbSet<StockPullOut> StockPullOuts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Shoe>()
            .HasMany(s => s.ColorVariations)
            .WithOne(v => v.Shoe)
            .HasForeignKey(v => v.ShoeId);
    }
}
