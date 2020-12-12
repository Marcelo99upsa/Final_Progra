using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Numero.Models
{
    public class Numero
    {
        
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Range(1, 9999)]
        public int Numeros { get; set; }
    }
}