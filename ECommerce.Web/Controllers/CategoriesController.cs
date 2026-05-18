using ECommerce.Application.DTOs.Category;
using ECommerce.Application.Interfaces.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoriesController(ICategoryService categoryService, IWebHostEnvironment webHostEnvironment)
        {
            _categoryService = categoryService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        public async Task<IActionResult> Create()
        {
            await PopulateParentCategoriesSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                await PopulateParentCategoriesSelectList();
                return View(dto);
            }

            var createdCategory = await _categoryService.CreateAsync(dto);

            if (dto.ImageFile != null && dto.ImageFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", "categories");
                if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

                string safeCategoryName = string.IsNullOrWhiteSpace(dto.NameEn) ? "Category" : SanitizeFileName(dto.NameEn);
                string uniqueFileName = $"{safeCategoryName}-{createdCategory.Id}.png";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.ImageFile.CopyToAsync(fileStream);
                }

                createdCategory.ImageUrl = $"/uploads/categories/{uniqueFileName}";

                var updateDto = new UpdateCategoryDto
                {
                    Id = createdCategory.Id,
                    NameAr = createdCategory.NameAr,
                    NameEn = createdCategory.NameEn,
                    ImageUrl = createdCategory.ImageUrl,
                    ParentCategoryId = createdCategory.ParentCategoryId,
                    IsActive = createdCategory.IsActive
                };
                await _categoryService.UpdateAsync(updateDto);
            }

            TempData["NotifyMessage"] = "Category created successfully!";

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            var model = new UpdateCategoryDto
            {
                Id = category.Id,
                NameAr = category.NameAr,
                NameEn = category.NameEn,
                ImageUrl = category.ImageUrl,
                ParentCategoryId = category.ParentCategoryId,
                IsActive = category.IsActive
            };

            await PopulateParentCategoriesSelectList(category.Id);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCategoryDto model)
        {
            if (!ModelState.IsValid)
            {
                await PopulateParentCategoriesSelectList(model.Id);
                return View(model);
            }

            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", "categories");
                if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

                string safeCategoryName = string.IsNullOrWhiteSpace(model.NameEn) ? "Category" : SanitizeFileName(model.NameEn);
                string fileExtension = Path.GetExtension(model.ImageFile.FileName);
                string uniqueFileName = $"{safeCategoryName}-{model.Id}{fileExtension}";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(fileStream);
                }

                model.ImageUrl = $"/uploads/categories/{uniqueFileName}";
            }

            await _categoryService.UpdateAsync(model);

            TempData["NotifyMessage"] = "Category updated successfully!";

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);

            TempData["NotifyMessage"] = "Category deleted successfully!";

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateParentCategoriesSelectList(int? currentCategoryId = null)
        {
            var categories = await _categoryService.GetAllAsync();
            var parentCategories = categories.Where(c => c.ParentCategoryId == null);

            if (currentCategoryId.HasValue)
            {
                parentCategories = parentCategories.Where(c => c.Id != currentCategoryId.Value);
            }

            ViewBag.ParentCategories = new SelectList(parentCategories, "Id", "NameEn");
        }

        private string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name.Replace(" ", "_"); 
        }
    }
}