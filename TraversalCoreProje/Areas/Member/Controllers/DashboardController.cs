﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    public class DashboardController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {

            _userManager = userManager;
        }
        [Area("Member")]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.userImage = values.ImageUrl;

            return View();
        }

        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }
    }
}
