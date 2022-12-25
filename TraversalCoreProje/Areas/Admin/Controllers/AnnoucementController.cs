using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnoucementController : Controller
    {
        private readonly IAnnoucementService _annoucementService;

        public AnnoucementController(IAnnoucementService annoucementService)
        {
            _annoucementService = annoucementService;
        }

        public IActionResult Index()
        {
            var values = _annoucementService.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddAnnoucement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnoucement(stirng x)
        {
            return View();
        }
    }
}
