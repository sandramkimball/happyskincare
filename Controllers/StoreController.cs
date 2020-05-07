using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeApp.Models;

namespace PracticeApp.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            var dummydata = new Product
            {
                Name = "Argan Oil",
                Description = "Apply to your hair ends to keep it looking healthy.",
                Price = 0699,
            };
            return View(dummydata);
        }

        public IActionResult Add()
        {
            var viewmodel = new Product();
            return View(viewmodel);
        }
    }
}