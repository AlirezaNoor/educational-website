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
    [PermissionChecker(2)]

    public class IndexModel : PageModel
    {
        private IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserForAdminViewModel UserForAdminViewModel { get; set; }

        public void OnGet(int pagrId=1,string filterUserName="",string filterEmail="")
        {
            UserForAdminViewModel = _userService.GetUsers(pagrId,filterEmail,filterUserName);
        }

       
    }
}