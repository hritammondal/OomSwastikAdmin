using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OomSwastikAdmin.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Item()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
    }
}
