using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pelika.Core.DTOs.Course;
using Pelika.Core.Services.Interfaces;

namespace Pelika.Web.Pages.Admin.Courses
{
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<ShowCourseForAdminViewModel> ListCouesr { get; set; }

        public void OnGet()
        {
            ListCouesr = _courseService.GetCoursesForAdmin();
        }
    }
}