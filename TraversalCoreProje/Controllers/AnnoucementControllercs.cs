using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class AnnoucementControllercs : Controller
    {
        private readonly IAnnoucementService _service;

        public AnnoucementControllercs(IAnnoucementService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            List<Annoucement> annoucements = _service.TGetList();
            List<AnnoucementListViewModel> model = new List<AnnoucementListViewModel>();
            foreach (var item in annoucements)
            {
                AnnoucementListViewModel annoucementListViewModel = new AnnoucementListViewModel();
                annoucementListViewModel.Title = item.Title;
                annoucementListViewModel.Content = item.Content;
                annoucementListViewModel.Id = item.Id;

                model.Add(annoucementListViewModel);

            }
            return View(model);

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
