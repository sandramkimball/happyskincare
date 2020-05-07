using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracticeApp.Models;

namespace PracticeApp.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {

            var dummydata = new List<Product>() 
            {
                new Product {
                    Name = "Argan Oil",
                    Description = "Apply to your hair ends to keep it looking healthy.",
                    Price = 0699,
                    Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
                },
                new Product {
                     Name = "Pomegranate Lip Balm",
                     Description = "Smells like spring.",
                     Price = 0199,
                     Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
                 }
            };


            return View(dummydata);
        }

    }
}