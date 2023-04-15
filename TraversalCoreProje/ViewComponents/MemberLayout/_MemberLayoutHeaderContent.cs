using Microsoft.AspNetCore.Mvc;

namespace AdvenTours.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}