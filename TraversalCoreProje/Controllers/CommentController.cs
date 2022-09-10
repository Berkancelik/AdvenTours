using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        /// <summary>
        /// Method to return ad commnet values
        /// </summary>
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        /// <summary>
        /// Method to return ad commnet values
        /// </summary>
        /// <param name="p">Comment Parameter</param>
        /// <returns></returns>

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
