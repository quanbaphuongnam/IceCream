using IceCream.Services;
using Microsoft.AspNetCore.Hosting;
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
        private RecipeService recipeService;
        private SavourService savourService;
        private IWebHostEnvironment webHostEnvironment;


        public RecipeController(SavourService _savourService, RecipeService _recipeService,IWebHostEnvironment _webHostEnvironment)
        {
            savourService = _savourService;
            recipeService = _recipeService;
        }
        [Route("recipe")]
        [Route("")]
   
        public IActionResult Index()
        {
            ViewBag.savours = savourService.FindAllSavour();
            ViewBag.recipes = recipeService.FindAllFormula();
            ViewBag.newrecipes = recipeService.FindAllNewFormula();
            return View("recipe");
        }
        [Route("recipedetail")]
        public IActionResult RecipeDetail()
        {
            return View("recipedetail");
        }
        [Route("postrecipe")]
        public IActionResult PostRecipe()
        {
            ViewBag.savours = savourService.FindAllSavour();
            return View("postrecipe");
        }
    }
}
