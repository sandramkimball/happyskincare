using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please enter the product name.")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [Display(Name = "Product Decription")]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        [RegularExpression(@"\d", ErrorMessage ="Numbers only.")]
        public int Price { get; set; }
    }
}
