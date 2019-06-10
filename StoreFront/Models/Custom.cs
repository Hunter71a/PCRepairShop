using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Models
{
    public class Custom
    {
        [Editable(false)]
        [Display(Name = "Central Processing Unit")]
        public string CPU { get; set; }
        [Editable(false)]
        [Display(Name = "Graphics Card")]
        public string GPU { get; set; }
        [Editable(false)]
        [Display(Name = "Case Model")]
        public string Case { get; set; }
        [Editable(false)]
        [Display(Name = "Cooling Option")]
        public string Cooling { get; set; }
    }
}
