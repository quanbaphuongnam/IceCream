using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers
{
    [Route("recipe")]
    public class RecipeController : Controller
    {
        [Route("recipe")]
        [Route("")]
   
        public IActionResult Index()
        {
            return View("recipe");
        }
        [Route("recipedetail")]
        public IActionResult RecipeDetail()
        {
            return View("recipedetail");
        }
    }
}
