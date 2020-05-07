using PracticeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            var listOfProd = new List<Product>()
            {

                new Product {
                    Name = "Jojoba Oil",
                    Description = "Intensely plumps and hydrates.",
                    Price = 0699,
                    Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
                },
                new Product {
                     Name = "Buzz Caffeine Cream",
                     Description = "Apply under eyes to depuff.",
                     Price = 1399,
                     Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
                 },
                new Product {
                     Name = "Mint Foam Wash",
                     Description = "Foaming face wash. Use morning or night and open those pores.",
                     Price = 1599,
                     Image = "https://images.unsplash.com/photo-1572635148818-ef6fd45eb394?ixlib=rb-1.2.1&auto=format&fit=crop&w=800&q=80",
                 }
            };
            return listOfProd;
        }
    }
}
