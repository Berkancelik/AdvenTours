using Microsoft.AspNetCore.Mvc;

namespace AdvenTours.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}