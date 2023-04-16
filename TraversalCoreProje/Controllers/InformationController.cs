using Microsoft.AspNetCore.Mvc;

namespace AdvenTours.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
