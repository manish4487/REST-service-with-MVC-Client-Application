using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAPP.Models
{
    public class mvcVehicleModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="This Field is Required")]
        public Nullable<int> Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


    }
}