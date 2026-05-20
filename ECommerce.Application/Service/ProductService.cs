using AutoMapper;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository , IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllByCategoryIdAsync(int categoryId)
        {
            var products =  await _productRepository.GetProductsByCategoryIdAsync(categoryId);

            if (products == null || !products.Any())
            {
                return Enumerable.Empty<ProductDto>();
            }

            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetAllProductDetailsAsync(id);
            return _mapper.Map<ProductDto>(product);
        }
        public async Task<ProductDto> CreateAsync(CreateProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            var createdProduct = await _productRepository.AddAsync(productEntity);

            return _mapper.Map<ProductDto>(createdProduct);
        }
        public async Task<ProductDto> UpdateAsync(UpdateProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            var updatedProduct = await _productRepository.UpdateAsync(productEntity);

            return _mapper.Map<ProductDto>(updatedProduct);
        }
        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

    }
}