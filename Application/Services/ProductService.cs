using AutoMapper;
using GolrangProductApi.Application.DTOs;
using GolrangProductApi.Application.Interfaces;
using GolrangProductApi.Domain.Entities;
using GolrangProductApi.Domain.Interfaces;

namespace GolrangProductApi.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.AddAsync(product);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<bool> UpdateProductAsync(int id, ProductDto productDto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return false; // Product not found
            }

            // Map changes from DTO to the existing product
            _mapper.Map(productDto, product);
            await _productRepository.UpdateAsync(product);
            return true; // Return true if update was successful
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
            {
                return false; // Product not found
            }
            await _productRepository.DeleteAsync(id);
            return true; // Return true if delete was successful
        }
    }
}
