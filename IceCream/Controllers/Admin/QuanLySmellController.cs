﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers.Admin
{
    [Route("quanlysmell")]
    public class QuanLySmellController : Controller
    {
        [Route("quanlysmell")]
        [Route("")]
        public IActionResult Index()
        {
            return View("quanlysmell");
        }
    }
}
