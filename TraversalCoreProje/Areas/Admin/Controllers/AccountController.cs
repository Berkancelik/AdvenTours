using BusinessLayer.Abstract.NewFolder.AbstractUnitOfWork;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    { 
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(AccountViewModel model)
        {
            var valueSender = _accountService.GetById(model.SenderId);
            var valueReceiver = _accountService.GetById(model.ReceiverId);
            valueSender.Balance -= model.Amount;
            valueReceiver.Balance += model.Amount;

            List<Account> modifiedAccount = new List<Account>()
            {
                valueSender,
                valueReceiver
            };
            _accountService.TMultiUpdate(modifiedAccount);
            return View();
        }
    }
}
