using AutoMapper;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.Interfaces.services;
using ECommerce.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Web.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public CategoriesController(
            ICategoryService categoryService,
            IMapper mapper,
            IFileStorageService fileStorageService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();

            var rootCategories = categories
                .Where(c => c.ParentCategoryId == null)
                .ToList();

            foreach (var parent in rootCategories)
            {
                parent.Children = categories
                    .Where(c => c.ParentCategoryId == parent.Id)
                    .ToList();
            }

            return View(rootCategories);
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

            if (dto.ImageFile != null)
            {
                string safeName = string.IsNullOrWhiteSpace(dto.NameEn) ? "Category" : dto.NameEn;
                string customName = $"{safeName}-{createdCategory.Id}";

                string fileUrl = await _fileStorageService.UploadFileAsync(dto.ImageFile, "categories", customName);

                if (!string.IsNullOrEmpty(fileUrl))
                {
                    createdCategory.ImageUrl = fileUrl;
                    var updateDto = _mapper.Map<UpdateCategoryDto>(createdCategory);
                    await _categoryService.UpdateAsync(updateDto);
                }
            }

            TempData["NotifyMessage"] = "Category created successfully!";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            var model = _mapper.Map<UpdateCategoryDto>(category);

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
                string safeName = string.IsNullOrWhiteSpace(model.NameEn) ? "Category" : model.NameEn;
                string customName = $"{safeName}-{model.Id}";

                string fileUrl = await _fileStorageService.UploadFileAsync(model.ImageFile, "categories", customName);

                if (!string.IsNullOrEmpty(fileUrl))
                {
                    model.ImageUrl = fileUrl;
                }
            }

            await _categoryService.UpdateAsync(model);

            TempData["NotifyMessage"] = "Category updated successfully!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);

            TempData["NotifyMessage"] = "Category deleted successfully!";
            return RedirectToAction("Index");
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
    }
}