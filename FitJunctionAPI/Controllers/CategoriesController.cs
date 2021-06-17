using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FitJunctionAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

      

        private List<Category> Categories = new List<Category> {

            new Category() { CategoryId = 1,  CategoryName = "T-Shirts"},
            new Category() { CategoryId = 2,  CategoryName = "Track Suits"},
            new Category() { CategoryId = 3,  CategoryName = "Swimming Suits"},
            new Category() { CategoryId = 4,  CategoryName = "Tennis Gear"}
        };

        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Category> Get()
        {

            return Categories;


        }

    }
}
