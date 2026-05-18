using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Service
{
    public class ProductService : GenericService<Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

    }
}