using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace pot_folio.Controllers
{
    public class downloadController : Controller
    {
      
        public IActionResult downloadimg(string image)
        {

            var Filebyte = System.IO.File.ReadAllBytes($"wwwroot/images/{image}");
            string Filename = image;
            return File(Filebyte, MediaTypeNames.Image.Jpeg, Filename);

        }

    }
}
