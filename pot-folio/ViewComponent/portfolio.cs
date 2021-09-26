using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace pot_folio.ViewComponent
{
    public class portfolio : Microsoft.AspNetCore.Mvc.ViewComponent
    {

        public ViewViewComponentResult Invoke()
        {
            return View("/Views/Home/component/portfolio.cshtml");
        }
    }
}
