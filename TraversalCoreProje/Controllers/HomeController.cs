﻿using AdvenTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using TraversalCoreProje.Models;

namespace AdvenTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index sayfası Çağrıldı");
            _logger.LogError("Log Error çağrıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d + "Privacy sayfası Çağrıldı");

            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfası çağrıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
