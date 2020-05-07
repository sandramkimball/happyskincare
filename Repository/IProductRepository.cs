using PracticeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//using dependency injection through inversion of control and clean design
namespace PracticeApp.Repository
{
    public interface IProductRepository
    {
        /// <summary>
        /// gets all products in the db
        /// </summary>
        /// <returns>list of products</returns>
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}


