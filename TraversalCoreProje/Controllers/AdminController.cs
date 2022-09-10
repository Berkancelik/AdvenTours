using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class AdminController : Controller
    {
        /// <summary>
        /// Partial Header partial field
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        /// <summary>
        /// Partial AppBrandDemo partial field
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        }
        /// <summary>
        /// Partial Sidebar partial field
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        /// <summary>
        /// Partial Navbar partial field
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        /// <summary>
        /// Partial Footer partial field
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        /// <summary>
        /// Partial Header PartialScript field
        /// </summary>
        /// <returns></returns>

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}
