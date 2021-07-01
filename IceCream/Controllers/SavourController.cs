using IceCream.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers
{
    public class SavourController : Controller
    {
       
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
