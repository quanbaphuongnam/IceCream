using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        
        [Route("allbook")]
        [Route("")]
        public IActionResult Index()
        {
            return View("allbook");
        }
        [Route("bookdetails")]
        public IActionResult BookDetails()
        {
            return View("bookdetails");
        }
    }
}
