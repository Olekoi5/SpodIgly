using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpodIglyMVC.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult Onas()
        {
            return View();
        }

        public IActionResult Regulamin()
        {
            return View();
        }

        public IActionResult Wysylka()
        {
            return View();
        }
    }
}
