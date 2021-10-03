using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pot_folio.Models
{
    public class contact
    {
     
        [Required(ErrorMessage = "please type name ")]
        public string name { get; set; }
        [Required(ErrorMessage = "please enter email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required(ErrorMessage = "please enter subject ")]
        public string subject { get; set; }

        public string message { get; set; }
    }

}
