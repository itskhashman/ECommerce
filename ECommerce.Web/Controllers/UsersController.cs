using ECommerce.Application.DTOs.User;
using ECommerce.Application.Interface.Service;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly IIdentityService _identityService;
    private readonly IUserService _userService;

    public UsersController(IIdentityService identityService, IUserService userService)
    {
        _identityService = identityService;
        _userService = userService;
    }

    [HttpGet("Manage/Users")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Manage()
    {
        var users = await _userService.GetAllUsersAsync();
        if (users == null) return NotFound();

        return View(users);
    }

    [HttpGet("Manage/Users/Create")]
    [Authorize(Roles = "Admin")]

    public IActionResult Create()
    {
        return View(new CreateUserDto());
    }

    [HttpPost("Manage/Users/Create")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(CreateUserDto model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Validation failed. Please correct the highlighted errors.";
            return View(model);
        }

        try
        {
            string identityRoleName = model.RoleId switch
            {
                1 => "Admin",
                2 => "Customer",
                _ => "Customer"
            };

            var success = await _identityService.RegisterAsync(
                model.UserName, model.Email, model.Password,
                model.FirstNameAr, model.MiddleNameAr, model.LastNameAr,
                model.FirstNameEn, model.MiddleNameEn, model.LastNameEn,
                model.Phone, model.RoleId, identityRoleName
            );

            if (success)
            {
                TempData["SuccessMessage"] = "User was added successfully!";
                return RedirectToAction("Manage");
            }

            TempData["ErrorMessage"] = "Registration rejected by identity rules.";
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = $"An error occurred: {ex.Message}";
        }

        return View(model);
    }

    [HttpGet("Manage/Users/Edit/{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(int id)
    {
        var user = await _userService.GetAllUsersAsync();
        var selectedUser = user?.FirstOrDefault(u => u.Id == id);

        if (selectedUser == null) return NotFound();

        var primaryRole = selectedUser.UserRoles?.FirstOrDefault()?.Role;

        var model = new UpdateUserDto
        {
            Id = selectedUser.Id,
            FirstNameEn = selectedUser.FirstNameEn,
            MiddleNameEn = selectedUser.MiddleNameEn,
            LastNameEn = selectedUser.LastNameEn,
            FirstNameAr = selectedUser.FirstNameAr,
            MiddleNameAr = selectedUser.MiddleNameAr,
            LastNameAr = selectedUser.LastNameAr,
            Email = selectedUser.Email,
            Phone = selectedUser.Phone,
            RoleId = primaryRole?.Id,
            IsActive = selectedUser.IsActive,
            IsEmailVerified = selectedUser.IsEmailVerified
        };

        return View(model);
    }

    [HttpPost("Manage/Users/Edit")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(UpdateUserDto model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = "Modifications failed validation rules.";
            return View(model); 
        }

        try
        {
            await _userService.UpdateUserInfo(model);
            TempData["SuccessMessage"] = "User information updated successfully!";
            return RedirectToAction("Manage");
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = $"Failed to update: {ex.Message}";
        }

        return View(model);
    }

    [HttpPost("Manage/Users/Delete/{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var success = await _identityService.DeleteAsync(id);

            if (success)
            {
                TempData["SuccessMessage"] = "User account was deactivated and locked out successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Could not locate the targeted user system record.";
            }
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = $"An error occurred during deactivation: {ex.Message}";
        }

        return RedirectToAction("Manage");
    }
}