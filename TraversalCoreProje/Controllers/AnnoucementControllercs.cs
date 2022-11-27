using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class AnnoucementControllercs : Controller
    {
        private readonly IAnnoucementService _service;

        public AnnoucementControllercs(IAnnoucementService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var values = _service.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddAnnoucement()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AddAnnoucement(string x)
        {
            return View();
        }

    }
}
