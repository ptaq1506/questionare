﻿using Microsoft.AspNetCore.Mvc;


namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
