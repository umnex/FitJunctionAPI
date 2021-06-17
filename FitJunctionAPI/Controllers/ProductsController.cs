using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FitJunctionAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

      

        private List<Product> Products = new List<Product> {

            new Product() { ProductId = 1,  ProductName = "Nike round neck T-Shirt", Price=30, CategoryId=1},
            new Product() { ProductId = 2,  ProductName = "Adidas running Track Suit", Price=90, CategoryId=2},
            new Product() {ProductId = 3,  ProductName = "Speedo Swimming Suit", Price=80, CategoryId=3},
            new Product() { ProductId = 4,  ProductName = "Dunlop Tennis Gear", Price=50, CategoryId=4}
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Product> Get()
        {

            return Products;


        }

    }
}
