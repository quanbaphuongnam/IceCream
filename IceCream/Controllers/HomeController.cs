using IceCream.Paypal;
using IceCream.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Areas.Admin.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private RecipeService recipeService;
        private IConfiguration configuration;
        public HomeController(RecipeService _recipeService, IConfiguration _configuration)
        {

            recipeService = _recipeService;
            configuration = _configuration;
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
     
        public IActionResult Index()
        {
            ViewBag.newrecipes = recipeService.FindAllNewFormula();
            ViewBag.postUrl = configuration["PayPal:PostUrl"];
            ViewBag.business = configuration["PayPal:Business"];
            ViewBag.returnUrl = configuration["PayPal:ReturnUrl"];
            return View();
        }
        [Route("signupsuccess")]
        public IActionResult Success([FromQuery(Name = "tx")] string tx)
        {
            var result = PDTHolder.Success(tx, configuration);
            Debug.WriteLine("Customer info:");
            Debug.WriteLine("First Name: " + result.PayerFirstName);
            Debug.WriteLine("LastName: " + result.PayerLastName);
            Debug.WriteLine("Email: " + result.PayerEmail);
            return View("signupsuccess");
        }

    }
}
