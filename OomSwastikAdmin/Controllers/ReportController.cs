using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OomSwastikAdmin.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult Stock()
        {
            return View();
        }
        public IActionResult Item()
        {
            return View();
        }
    }
}
