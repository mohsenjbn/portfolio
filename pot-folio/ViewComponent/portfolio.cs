using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using pot_folio.Models;

namespace pot_folio.ViewComponent
{
    public class portfolio : Microsoft.AspNetCore.Mvc.ViewComponent
    {

        public ViewViewComponentResult Invoke()
        {
            var portfolios=new List<portfoliomodel>()
            {
                new portfoliomodel()
                {
                    Id = 1,
                  subject = "سعید هویجی",
                  Describtion = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the",
                  image = "work-1.jpg"
                },
                new portfoliomodel()
                {
                    Id = 2,
                    subject = "Black & Gold Paint Face",
                    Describtion = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the",
                    image = "work-2.jpg"
                },
                new portfoliomodel()
                {
                    Id = 3,
                    subject = "Black & Gold Paint Face",
                    Describtion = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the",
                    image = "work-3.jpg"
                }

            };
            
            return View("/Views/Home/component/portfolio.cshtml",portfolios);
        }
    }
}
