using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using pot_folio.Models;

namespace pot_folio.ViewComponent
{
    public class menucomponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var menus = new List<menu>()
           {
               new menu()
               {
                   Id = 1,
                   Name = "Home",
                   controller = "Home",
                   Action = "Index",

               },
               new menu()
               {
                   Id = 2,
                   Name = "Gallery",
                   controller = "Home",
                   Action = "Gallery",

               },
               new menu()
               {
                   Id = 3,
                   Name = "About",
                   controller = "Home",
                   Action = "About",

               },
               new menu()
               {
                   Id = 4,
                   Name = "contact",
                   controller = "Home",
                   Action = "contact",

               },
           };



            return View("/Views/Home/component/menus.cshtml", menus);
        }
    }
}
