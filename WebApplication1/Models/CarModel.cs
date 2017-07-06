using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarModel
    {   
        [Key]
        public int CarId { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Company { get; set; }

        public int CarNum { get; set; }
        public int CaNum { get; set; }
    }
}