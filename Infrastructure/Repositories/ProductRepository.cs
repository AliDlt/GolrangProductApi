using GolrangProductApi.Domain.Entities;
using GolrangProductApi.Domain.Interfaces;
using GolrangProductApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GolrangProductApi.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.ProductGroup)
                .Include(p => p.WorkType)
                .Include(p => p.ProductAdts)
                .Include(p => p.ProductPrices)
                .Include(p => p.ProductSizes)
                .Include(p => p.ProductMaterials)
                .Include(p => p.ProductPrintKinds)
                .Include(p => p.ProductDelivers)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.ProductGroup)
                .Include(p => p.WorkType)
                .Include(p => p.ProductAdts)
                .Include(p => p.ProductPrices)
                .Include(p => p.ProductSizes)
                .Include(p => p.ProductMaterials)
                .Include(p => p.ProductPrintKinds)
                .Include(p => p.ProductDelivers)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            return await _context.SaveChangesAsync() > 0; // Return true if the update was successful
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync() > 0; // Return true if the delete was successful
            }
            return false; // Product not found
        }
    }
}
