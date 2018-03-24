using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category ="Groceries",Price=1},
            new Product { Id = 2, Name = "Yo-yo", Category ="Toys",Price=3},
            new Product { Id = 3, Name = "Hammer", Category ="Hardware",Price=16}

        };
        //Get : api/Products
        public IEnumerable<Product>  GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var objProduct = products.FirstOrDefault(p => p.Id == id);
            if(objProduct == null)
            {
                return NotFound();
            }
            return Ok(objProduct);
        }
    }
}
