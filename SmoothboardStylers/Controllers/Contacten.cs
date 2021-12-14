using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Controllers
{
    public class Contacten : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
