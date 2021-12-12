using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.DTOs;
using Pelika.Core.Security;
using Pelika.Core.Services.Interfaces;
using Pelika.DataLayer.Entities.User;

namespace Pelika.Web.Pages.Admin.Roles
{
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public List<Role> RolesList { get; set; }
        
        public void OnGet()
        {
            RolesList = _permissionService.GetRoles();
        }

       
    }
}