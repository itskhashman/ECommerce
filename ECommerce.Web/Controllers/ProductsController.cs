using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult>  Index()
        {
            var products = await _productService.GetAllByCategoryIdAsync(13);
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetByIdAsync(id);

            return View(product);
        }

        public async Task<IActionResult> Create()
        {
            var SubCategories = await _categoryService.GetAllSubCategoriesAsync();
            var MainCategories = await _categoryService.GetAllMainCategoriesAsync();
            ViewBag.MainCategories = new SelectList(MainCategories, "Id", "NameEn");
            ViewBag.SubCategories = new SelectList(SubCategories, "Id", "NameEn");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.MainCategories = new SelectList(await _categoryService.GetAllMainCategoriesAsync(), "Id", "NameEn");
                ViewBag.SubCategories = new SelectList(await _categoryService.GetAllSubCategoriesAsync(), "Id", "NameEn");
                return View(product);
            }
            var createdProduct = _productService.CreateAsync(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _productService.GetByIdAsync(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(UpdateProductDto product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            var updatedProduct = _productService.UpdateAsync(product);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _productService.DeleteAsync(id);
            return RedirectToAction("index");
        }
    }
}
