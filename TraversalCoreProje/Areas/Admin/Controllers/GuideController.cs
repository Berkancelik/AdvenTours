using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class GuideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
