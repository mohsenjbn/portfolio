using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace pot_folio.Models
{
    public class contact
    {
     
        [Required(ErrorMessage = "please type name ")]
        public string name { get; set; }
        [Required(ErrorMessage = "please enter email")]
        [EmailAddress(ErrorMessage = "enter email adrress")]
        public string email { get; set; }
        [Required(ErrorMessage = "please enter subject ")]
        public SelectList subjects { get; set; }

        public string message { get; set; }
    }

}
