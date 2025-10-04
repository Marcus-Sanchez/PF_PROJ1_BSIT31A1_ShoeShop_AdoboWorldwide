using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PF.Repository
{
    public class ShoeShopDbContextFactory : IDesignTimeDbContextFactory<ShoeShopDbContext>
    {
        public ShoeShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShoeShopDbContext>();
            optionsBuilder.UseSqlite("Data Source=shoe_inventory.db"); // match appsettings.json
            return new ShoeShopDbContext(optionsBuilder.Options);
        }
    }
}
