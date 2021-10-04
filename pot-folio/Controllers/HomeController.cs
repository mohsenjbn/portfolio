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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace pot_folio.Controllers
{
    public class HomeController : Controller
    {
       private readonly List<subject> _subjects=new List<subject>()
       {
           new subject(1,"work"),
           new subject(2,"personal"),
           new subject(3,"add team")

       };


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
            var model=new contact()
            {
                subjects = new SelectList(_subjects,"Id","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult contact(contact modelContact)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "Please enter the correct information ";
                return View(modelContact);
            }

            ViewBag.sendsucsses = "Message sent successfully";
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
