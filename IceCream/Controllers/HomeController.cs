using IceCream.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Areas.Admin.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private RecipeService recipeService;
        public HomeController(RecipeService _recipeService)
        {

            recipeService = _recipeService;
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
     
        public IActionResult Index()
        {
            ViewBag.newrecipes = recipeService.FindAllNewFormula();
            return View();
        }
       
    }
}
