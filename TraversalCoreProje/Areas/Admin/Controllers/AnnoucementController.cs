using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnoucmenetDTOs;
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
        private readonly IMapper _mapper;

        public AnnoucementController(IAnnoucementService annoucementService, IMapper mapper)
        {
            _annoucementService = annoucementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnoucmeentListDTOs>>(_annoucementService.TGetList());
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
