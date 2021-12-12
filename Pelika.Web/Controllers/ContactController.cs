using Microsoft.AspNetCore.Mvc;
using Pelika.DataLayer.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pelika.Core.Senders;
using Pelika.Core.Services.Interfaces;

namespace Pelika.Web.Controllers
{
    public class ContactController : Controller
    {
        private IUserService _userService;
        public ContactController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("Contactus")]
        public IActionResult ContactMail()
        {
            return View();
        }
        [HttpPost]
        [Route("Contactus")]
        public async Task<IActionResult> ContactMail(ContactUs contactUs)
        {
            var msg =" ایمیل :"+contactUs.Email+ "<br>نام :"+ contactUs.Name + "<br>پیام : " + contactUs.Massage;
            await _userService.SendEmailAsync(contactUs.Email, "Contact Mail", msg);
            return View("_SendContactUsEmail");
        }
    }
}
