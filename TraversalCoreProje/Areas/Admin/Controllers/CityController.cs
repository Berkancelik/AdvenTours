using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        }



        public static List<CityClass> cities = new List<CityClass>()
        {
            new CityClass()
            {
                Id = 1,
                Name ="Ardahan",
                Country = "Türkiye"
            },
               new CityClass()
            {
                Id = 1,
                Name ="Anakara",
                Country = "Türkiye"
            },
                  new CityClass()
            {
                Id = 1,
                Name ="Kars",
                Country = "Türkiye"
            }

        };

    }
}
