﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCream.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        [Route("cart")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
