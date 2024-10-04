using GolrangProductApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GolrangProductApi.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdt> ProductAdts { get; set; }
        public DbSet<ProductAdtType> ProductAdtTypes { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductDeliver> ProductDelivers { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductMaterialAttribute> ProductMaterialAttributes { get; set; }
    }

}
