using IceCream.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers.Admin
{
    [Route("quanlybook")]
    public class QuanLyBookController : Controller
    {
        private QuanLyBookServices quanlybookServices;
        private IWebHostEnvironment webHostEnvironment;


        public QuanLyBookController(QuanLyBookServices _quanlybookServices, IWebHostEnvironment _webHostEnvironment)
        {
            quanlybookServices = _quanlybookServices;

        }
        [Route("quanlybook")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.quanlybooks = quanlybookServices.FindAllBook();
           
            return View("quanlybook");
        }
    }
}
