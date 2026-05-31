using AutoMapper;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces.services;
using ECommerce.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public ProductsController(
            IProductService productService,
            ICategoryService categoryService,
            IMapper mapper,
            IFileStorageService fileStorageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProductsWithMainImageAsync();
            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public async Task<IActionResult> Create()
        {
            await PopulateDropdownsAsync();
            ViewBag.SubCategories = new SelectList(Enumerable.Empty<SelectListItem>());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                await PopulateDropdownsAsync();
                return View(dto);
            }

            if (dto.ProductVariants != null && dto.ProductVariants.Any())
            {
                dto.ProductVariants = dto.ProductVariants
                    .Where(v => !string.IsNullOrEmpty(v.NameEn))
                    .ToList();

                foreach (var variant in dto.ProductVariants)
                {
                    if (variant.ProductVariantOptions != null)
                    {
                        var optionsList = variant.ProductVariantOptions.ToList();
                        for (int i = 0; i < optionsList.Count; i++)
                        {
                            optionsList[i].SortOrder = i;
                        }
                        variant.ProductVariantOptions = optionsList;
                    }
                }
            }

            dto.ProductImages = new List<ProductImageDto>();
            if (dto.ImageFiles != null && dto.ImageFiles.Any())
            {
                string safeName = string.IsNullOrWhiteSpace(dto.NameEn) ? "Product" : dto.NameEn;
                string fileUniqueSuffix = Guid.NewGuid().ToString().Substring(0, 5);

                for (int i = 0; i < dto.ImageFiles.Count; i++)
                {
                    var file = dto.ImageFiles[i];
                    if (file.Length > 0)
                    {
                        string customName = $"{safeName}-{fileUniqueSuffix}-{i}";
                        string fileUrl = await _fileStorageService.UploadFileAsync(file, "products", customName);

                        if (!string.IsNullOrEmpty(fileUrl))
                        {
                            dto.ProductImages.Add(new ProductImageDto
                            {
                                URL = fileUrl,
                                IsMain = (i == 0),
                                AltText = $"{dto.NameEn} Image {i + 1}",
                                SortOrder = i
                            });
                        }
                    }
                }
            }

            await _productService.CreateAsync(dto);

            TempData["NotifyMessage"] = "Product along with its variants created successfully!";
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UpdateProductDto>(product);
            await PopulateEditDropdownsAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductDto product)
        {
            if (!ModelState.IsValid)
            {
                await PopulateEditDropdownsAsync(product);
                return View(product);
            }

            if (product.ImageFiles != null && product.ImageFiles.Any())
            {
                string safeProductName = string.IsNullOrWhiteSpace(product.NameEn) ? "Product" : product.NameEn;

                for (int i = 0; i < product.ImageFiles.Count; i++)
                {
                    var file = product.ImageFiles[i];
                    if (file.Length > 0)
                    {
                        string customName = $"{safeProductName}-{product.Id}-edit-{Guid.NewGuid().ToString().Substring(0, 5)}";
                        string fileUrl = await _fileStorageService.UploadFileAsync(file, "products", customName);

                        if (!string.IsNullOrEmpty(fileUrl))
                        {
                            product.ProductImages.Add(new ProductImageDto
                            {
                                ProductId = product.Id,
                                URL = fileUrl,
                                IsMain = false,
                                AltText = $"{product.NameEn} Image Update",
                                SortOrder = i + 10
                            });
                        }
                    }
                }
            }

            await _productService.UpdateAsync(product);
            TempData["NotifyMessage"] = "Product variations updated successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetSubCategories(int mainCategoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByMainCategoryIdAsync(mainCategoryId);
            return Json(subCategories.Select(c => new { id = c.Id, name = c.NameEn }));
        }
        [HttpGet]
        private async Task PopulateDropdownsAsync()
        {
            var mainCategories = await _categoryService.GetAllMainCategoriesAsync();
            var discountTypes = await _productService.GetDiscountTypesAsync();
            ViewBag.DiscountTypes = new SelectList(discountTypes, "Id", "NameEn");
            ViewBag.MainCategories = new SelectList(mainCategories, "Id", "NameEn");
        }
        [HttpGet]
        private async Task PopulateEditDropdownsAsync(UpdateProductDto model)
        {
            var mainCategories = await _categoryService.GetAllMainCategoriesAsync();
            var subCategories = await _categoryService.GetAllSubCategoriesAsync();

            CategoryDto mainCategory = subCategories.FirstOrDefault(cat => cat.Id == model.CategoryId);
            if (mainCategory != null)
            {
                model.MainCategoryId = (int)mainCategory.ParentCategoryId;
            }

            var discountTypes = await _productService.GetDiscountTypesAsync();
            ViewBag.MainCategories = new SelectList(mainCategories, "Id", "NameEn");
            ViewBag.SubCategories = new SelectList(subCategories.Where(cat => cat.ParentCategoryId == model.MainCategoryId).ToList(), "Id", "NameEn");
            ViewBag.DiscountTypes = new SelectList(discountTypes, "Id", "NameEn");
        }
    }
}