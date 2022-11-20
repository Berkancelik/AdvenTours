using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class ContactUsCntroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
