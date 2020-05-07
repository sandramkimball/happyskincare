using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracticeApp.Models;
using PracticeApp.Repository;

namespace PracticeApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository repository)
        {
            // Be sure to register this new service in Startup
            _productRepository = repository;
        }


        // GET: Product
        public ActionResult Index()
        {
            //var repository = new ProductRepository();

            return View(_productRepository.GetProducts());
        }

        // GET: Product/Details/5
        public JsonResult Details(int id)
        {
            var testProduct = new Product
            {
                Name = "Pomegranate LipBalm",
                Description = "Smells like spring.",
                Price = 0199,
                Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
            };

            return Json(JsonConvert.SerializeObject(testProduct));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create([FromBody] Product product)
        {
            try
            {
                // TODO: Add insert logic here

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}