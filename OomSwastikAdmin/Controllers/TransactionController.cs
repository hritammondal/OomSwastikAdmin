using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OomSwastikAdmin.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult Stock()
        {
            return View();
        }
    }
}
