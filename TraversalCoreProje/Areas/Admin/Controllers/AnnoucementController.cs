using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [AllowAnonymous]
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
            List<Annoucement> annoucements = _annoucementService.TGetList();
            List<AnnoucementListViewModel> model = new List<AnnoucementListViewModel>();
            foreach (var item in annoucements)
            {
                AnnoucementListViewModel annoucementListViewModel = new AnnoucementListViewModel();
                annoucementListViewModel.Id = item.Id;
                annoucementListViewModel.Title = item.Title;
                annoucementListViewModel.Content = item.Content;
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
