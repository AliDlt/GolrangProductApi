using GolrangProductApi.Application.DTOs;

namespace GolrangProductApi.Application.Interfaces
{
    public interface IProductService
    {
        // Get product by ID
        Task<ProductDto> GetProductByIdAsync(int id);

        // Get all products
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();

        // Create a new product and return the created ProductDto
        Task<ProductDto> CreateProductAsync(ProductDto productDto);

        // Update an existing product and return a boolean indicating success
        Task<bool> UpdateProductAsync(int id, ProductDto productDto);

        // Delete a product by ID and return a boolean indicating success
        Task<bool> DeleteProductAsync(int id);
    }
}
