using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace FitJunctionAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

      

        private static List<Category> Categories = new List<Category> {

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
        public ActionResult<List<Category>> Get(string categoryname = null)
        {

            if (categoryname == null)
            {

                return Categories;

            }
            else
            {

                return Ok(Categories.FindAll(e => e.CategoryName.ToLower().StartsWith(categoryname.ToLower())));

            }
        }


        [HttpPost]
        public ActionResult Post(Category category)

        {


            if (Categories.Find(c => c.CategoryId==category.CategoryId || c.CategoryName.ToLower()==category.CategoryName.ToLower()) == null)
            {
                
                
                Categories.Add(category);

                return Ok();



            }
            else
            {


                return Conflict(new { status = 409, title = "Conflict",  message="Category Id or Category Name already exists." });




            }
            
            

           
           
        }



    }
}
