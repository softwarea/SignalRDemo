﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
    }
}
