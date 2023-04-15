using Microsoft.AspNetCore.Mvc;

namespace AdvenTours.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}