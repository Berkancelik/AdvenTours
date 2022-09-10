using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        /// <summary>
        ///  The method in which index values ​​are checked
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View();
        }

        /// <summary>
        /// The method in which DeleteUser values ​​are checked
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// The method in which EditUser values ​​are checked {GET}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditUser(int id)
        {var values = _appUserService.TGetByID(id);
            return View(values);

        }

        /// <summary>
        /// The method in which EditUser values ​​are checked{POST}
        /// </summary>
        /// <param name="appUser"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
           _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// The method in which CommentUser values ​​are checked
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }

        /// <summary>
        /// The method in which ReservationUser values ​​are checked
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservaitonByAccepted(id);
            return View(values);
        }
    }
}
