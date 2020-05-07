using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Models
{
    public class Product
    {
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Decription")]
        public string Description { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }
    }
}
