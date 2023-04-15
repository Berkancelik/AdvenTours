using Microsoft.AspNetCore.Mvc;

namespace AdvenTours.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}