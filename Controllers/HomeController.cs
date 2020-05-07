using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeApp.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            var newUpMyModel = new Product
            {
                Name = "Honey Moisturizer",
                Description = "Honey nourishes delicate skin with vitamins to refresh and hydrate and glow.",
                Price = 0399,
            };
            return View(newUpMyModel);
        }
    }
}
