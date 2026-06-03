using AutoMapper;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariant.NestedVariant;
using ECommerce.Application.DTOs.ProductVariant.SimpleVariant;
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

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsWithMainImageAsync()
        {
            var productsWithImages = await _productRepository.GetAllProductsWithMainImageAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(productsWithImages);
        }
        public async Task<IEnumerable<ProductDto>> GetAllByCategoryIdAsync(int categoryId)
        {
            var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId);
            if (products == null || !products.Any())
            {
                return Enumerable.Empty<ProductDto>();
            }
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
        public async Task<UpdateProductDto> GetProductWithAllDetailsAsync(int productId)
        {
            var productEntity = await _productRepository.GetAllProductDetailsAsync(productId);
            if (productEntity == null) return null;

            return MapProductToUpdateDto(productEntity);
        }
        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetAllProductDetailsAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<DiscountTypeDto>> GetDiscountTypesAsync()
        {
            var discountTypes = await _productRepository.GetDiscountTypesAsync();

            return _mapper.Map<IEnumerable<DiscountTypeDto>>(discountTypes);
        }

        public async Task<ProductDto> CreateAsync(CreateProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);

            var createdProduct = await _productRepository.AddAsync(productEntity);
            return _mapper.Map<ProductDto>(createdProduct);
        }

        public async Task<ProductDto> CreateProductWithVariantsAsync(CreateProductDto dto)
        {
            var productEntity = MapCreateDtoToProductEntity(dto);

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

        private UpdateProductDto MapProductToUpdateDto(Product productEntity)
        {
            var updateDto = _mapper.Map<UpdateProductDto>(productEntity);
            updateDto.HasNestedVariants = productEntity.HasNestedVariants;

            updateDto.SimpleProductVariants = new List<SimpleVariantDto>();
            updateDto.NestedProductVariants = new List<NestedVariantDto>();

            var productVariants = productEntity.ProductVariants ?? new List<ProductVariant>();
            var skus = productEntity.Skus ?? new List<Sku>();

            if (!productEntity.HasNestedVariants)
            {
                foreach (var variantEntity in productVariants)
                {
                    var simpleVariant = new SimpleVariantDto
                    {
                        NameEn = variantEntity.NameEn,
                        NameAr = variantEntity.NameAr,
                        Options = new List<SimpleOptionDto>()
                    };

                    foreach (var optionEntity in variantEntity.ProductVariantOptions)
                    {
                        var matchingSku = skus.FirstOrDefault(s => s.SKUJoinOptions != null &&
                            s.SKUJoinOptions.Any(jo => jo.ProductVariantOptionsId == optionEntity.Id));

                        if (matchingSku != null)
                        {
                            simpleVariant.Options.Add(new SimpleOptionDto
                            {
                                NameEn = optionEntity.NameEn,
                                NameAr = optionEntity.NameAr,
                                Price = matchingSku.Price,
                                Stock = matchingSku.Stock
                            });
                        }
                    }
                    updateDto.SimpleProductVariants.Add(simpleVariant);
                }
            }

            else
            {
                var orderedVariants = productVariants.OrderBy(v => v.Id).ToList();
                if (orderedVariants.Count >= 2)
                {
                    var configMainVariant = orderedVariants[0]; 
                    var configSubVariant = orderedVariants[1];

                    foreach (var sku in skus)
                    {
                        if (sku.SKUJoinOptions == null || sku.SKUJoinOptions.Count < 2) continue;

                        var joinOptions = sku.SKUJoinOptions.ToList();
                        var opt1 = joinOptions[0].ProductVariantOptions;
                        var opt2 = joinOptions[1].ProductVariantOptions;

                        if (opt1 == null || opt2 == null) continue;

                        ProductVariantOptions mainOptionEntity = null;
                        ProductVariantOptions subOptionEntity = null;

                        if (opt1.ProductVariantId == configMainVariant.Id)
                        {
                            mainOptionEntity = opt1;
                            subOptionEntity = opt2;
                        }
                        else if (opt2.ProductVariantId == configMainVariant.Id)
                        {
                            mainOptionEntity = opt2;
                            subOptionEntity = opt1;
                        }

                        if (mainOptionEntity == null || subOptionEntity == null) continue;

                        var nestedVariantDto = updateDto.NestedProductVariants
                            .FirstOrDefault(v => v.Id == configMainVariant.Id);
                        if (nestedVariantDto == null)
                        {
                            nestedVariantDto = new NestedVariantDto
                            {
                                Id = configMainVariant.Id,
                                NameEn = configMainVariant.NameEn,
                                NameAr = configMainVariant.NameAr,
                                Options = new List<NestedMainOptionDto>()
                            };
                            updateDto.NestedProductVariants.Add(nestedVariantDto);
                        }

                        var mainOptionDto = nestedVariantDto.Options
                            .FirstOrDefault(o => o.Id == mainOptionEntity.Id);
                        if (mainOptionDto == null)
                        {
                            mainOptionDto = new NestedMainOptionDto
                            {
                                Id = mainOptionEntity.Id,
                                NameEn = mainOptionEntity.NameEn,
                                NameAr = mainOptionEntity.NameAr,
                                SubVariants = new List<NestedSubVariantDto>()
                            };
                            nestedVariantDto.Options.Add(mainOptionDto);
                        }

                        var subVariantDto = mainOptionDto.SubVariants
                            .FirstOrDefault(sv => sv.Id == configSubVariant.Id);
                        if (subVariantDto == null)
                        {
                            subVariantDto = new NestedSubVariantDto
                            {
                                Id = configSubVariant.Id,
                                NameEn = configSubVariant.NameEn,
                                NameAr = configSubVariant.NameAr,
                                SubOptions = new List<NestedSubOptionDto>()
                            };
                            mainOptionDto.SubVariants.Add(subVariantDto);
                        }

                        if (!subVariantDto.SubOptions.Any(so => so.Id == subOptionEntity.Id))
                        {
                            subVariantDto.SubOptions.Add(new NestedSubOptionDto
                            {
                                Id = subOptionEntity.Id,
                                NameEn = subOptionEntity.NameEn,
                                NameAr = subOptionEntity.NameAr,
                                Price = sku.Price,
                                Stock = sku.Stock
                            });
                        }
                    }
                }
            }

            return updateDto;
        }
        private Product MapCreateDtoToProductEntity(CreateProductDto dto)
        {
            var productEntity = _mapper.Map<Product>(dto);
            productEntity.ProductVariants = new List<ProductVariant>();
            productEntity.Skus = new List<Sku>();

            var variantCache = new Dictionary<string, ProductVariant>();
            var optionCache = new Dictionary<string, ProductVariantOptions>();

            string baseProductCode = dto.NameEn.Replace(" ", "").ToUpper();
            if (baseProductCode.Length > 6) baseProductCode = baseProductCode.Substring(0, 6);


            if (!dto.HasNestedVariants && dto.SimpleProductVariants?.Any() == true)
            {
                foreach (var simpleVar in dto.SimpleProductVariants)
                {
                    var variant = new ProductVariant
                    {
                        NameEn = simpleVar.NameEn,
                        NameAr = simpleVar.NameAr,
                        ProductVariantOptions = new List<ProductVariantOptions>()
                    };

                    foreach (var opt in simpleVar.Options)
                    {
                        var option = new ProductVariantOptions { NameEn = opt.NameEn, NameAr = opt.NameAr };
                        variant.ProductVariantOptions.Add(option);

                        string variantCode = opt.NameEn.Replace(" ", "").ToUpper();
                        var sku = new Sku
                        {
                            SkuCode = $"{baseProductCode}-{variantCode}",
                            Price = opt.Price,
                            Stock = opt.Stock,
                            IsActive = true,
                            SKUJoinOptions = new List<SKUProductVariantOptions>()
                        };

                        sku.SKUJoinOptions.Add(new SKUProductVariantOptions { ProductVariantOptions = option, Sku = sku });
                        productEntity.Skus.Add(sku);
                    }
                    productEntity.ProductVariants.Add(variant);
                }
            }

            else if (dto.HasNestedVariants && dto.NestedProductVariants?.Any() == true)
            {
                foreach (var nestedVar in dto.NestedProductVariants)
                {
                    if (!variantCache.TryGetValue(nestedVar.NameEn, out var mainVariant))
                    {
                        mainVariant = new ProductVariant { NameEn = nestedVar.NameEn, NameAr = nestedVar.NameAr, ProductVariantOptions = new List<ProductVariantOptions>() };
                        variantCache[nestedVar.NameEn] = mainVariant;
                        productEntity.ProductVariants.Add(mainVariant);
                    }

                    foreach (var mainOpt in nestedVar.Options)
                    {
                        string mainOptKey = $"{nestedVar.NameEn}_{mainOpt.NameEn}";
                        if (!optionCache.TryGetValue(mainOptKey, out var mainOptionEntity))
                        {
                            mainOptionEntity = new ProductVariantOptions { NameEn = mainOpt.NameEn, NameAr = mainOpt.NameAr };
                            optionCache[mainOptKey] = mainOptionEntity;
                            mainVariant.ProductVariantOptions.Add(mainOptionEntity);
                        }

                        foreach (var subVar in mainOpt.SubVariants)
                        {
                            if (!variantCache.TryGetValue(subVar.NameEn, out var subVariant))
                            {
                                subVariant = new ProductVariant { NameEn = subVar.NameEn, NameAr = subVar.NameAr, ProductVariantOptions = new List<ProductVariantOptions>() };
                                variantCache[subVar.NameEn] = subVariant;
                                productEntity.ProductVariants.Add(subVariant);
                            }

                            foreach (var subOpt in subVar.SubOptions)
                            {
                                string subOptKey = $"{subVar.NameEn}_{subOpt.NameEn}";
                                if (!optionCache.TryGetValue(subOptKey, out var subOptionEntity))
                                {
                                    subOptionEntity = new ProductVariantOptions { NameEn = subOpt.NameEn, NameAr = subOpt.NameAr };
                                    optionCache[subOptKey] = subOptionEntity;
                                    subVariant.ProductVariantOptions.Add(subOptionEntity);
                                }

                                string mainCode = mainOpt.NameEn.Replace(" ", "").ToUpper();
                                string subCode = subOpt.NameEn.Replace(" ", "").ToUpper();

                                var sku = new Sku
                                {
                                    SkuCode = $"{baseProductCode}-{mainCode}-{subCode}",
                                    Price = subOpt.Price,
                                    Stock = subOpt.Stock,
                                    IsActive = true,
                                    SKUJoinOptions = new List<SKUProductVariantOptions>()
                                };

                                sku.SKUJoinOptions.Add(new SKUProductVariantOptions { ProductVariantOptions = mainOptionEntity, Sku = sku });
                                sku.SKUJoinOptions.Add(new SKUProductVariantOptions { ProductVariantOptions = subOptionEntity, Sku = sku });

                                productEntity.Skus.Add(sku);
                            }
                        }
                    }
                }
            }

            return productEntity;
        }
    }

}