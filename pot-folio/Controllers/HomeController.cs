using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pot_folio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mime;

namespace pot_folio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult download(string image)
        {
            
            var Filebyte = System.IO.File.ReadAllBytes($"wwwroot/images/{image}");
            string Filename = image;
            return File(Filebyte, MediaTypeNames.Image.Jpeg, Filename);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
