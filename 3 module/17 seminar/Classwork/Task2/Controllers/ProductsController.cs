using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController
    {
        private static List<Product> list = new List<Product>
        {
            new Product(){Id=1,Name = "Tomato", Price = 12},
            new Product(){Id=2,Name = "Apple", Price = 140},
            new Product(){Id=3,Name = "Mango", Price = 4325},
        };

        [HttpGet]
        public IEnumerable<Product> Get() => list;
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = list.SingleOrDefault(p => p.Id == id);
            if(product == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(product);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            list.Remove(list.SingleOrDefault(p => p.Id == id));
            return new OkResult();
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = 123;
            list.Add(product);
            return new CreatedResult(nameof(Get), product);
        }

        [HttpPost("AddProduct")]
        public IActionResult PostBody([FromBody] Product product) =>
            Post(product);

        private int NextProductId =>
            list.Count() == 0 ? 1 : list.Max(x => x.Id) + 1;

        [HttpGet("GetNextProductId")]
        public int GetNextProductId()
        {
            return NextProductId;
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            var storedProduct = list.SingleOrDefault(p => p.Id == product.Id);
            if (storedProduct == null) return new NotFoundResult();
            storedProduct.Name = product.Name;
            storedProduct.Price = product.Price;
            return new OkObjectResult(storedProduct);
        }

        [HttpPut("PutProduct")]
        public IActionResult PutBody([FromBody] Product product) =>
            Put(product);
    }
}
