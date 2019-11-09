using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using tangen_dataportal_version2.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tangen.Models;
//using tangen_dataportal_version2.Models;

namespace tangen_dataportal_version2.Controllers
{
    public class HomeController : Controller
    {

        public databaseContext _context;

        public HomeController(databaseContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Run()
        {
            return View();
        }

        public IActionResult Instruments()
        {
            return View();
        }

        public IActionResult Metrics()
        {
            return View();
        }
    }
}
