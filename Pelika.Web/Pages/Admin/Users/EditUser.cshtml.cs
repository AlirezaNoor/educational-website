using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.DTOs;
using Pelika.Core.Security;
using Pelika.Core.Services.Interfaces;

namespace Pelika.Web.Pages.Admin.Users
{
    [PermissionChecker(4)]

    public class EditUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _userService.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.EditUserFromAdmin(EditUserViewModel);
            //Edit Roles
            _permissionService.EditRolesUser(EditUserViewModel.UserId,SelectedRoles);

            return RedirectToPage("Index");
        }
    }
}