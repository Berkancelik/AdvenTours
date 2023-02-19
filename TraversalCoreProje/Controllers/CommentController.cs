using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            //ViewBag.Id = id;
            //var value =  _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userId = value.Id;

            return PartialView();
        }



        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.DestinationId = 3;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }


    }
}
