using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAjax.Models
{
    public class CalculatorModel
    {
        [Display(Name = "Number1")]
        public int Number1 { get; set; }

        [Display(Name = "Number2")]
        public int Number2 { get; set; }

        [Display(Name = "Result")]
        public int Result { get; set; }
    }

}