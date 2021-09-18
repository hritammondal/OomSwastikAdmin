using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OomSwastikAdmin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult signup()
        {
            return View();
        }
        public IActionResult signin()
        {
            return View();
        }
        public IActionResult RecoverPassword()
        {
            return View();
        }
    }
}
