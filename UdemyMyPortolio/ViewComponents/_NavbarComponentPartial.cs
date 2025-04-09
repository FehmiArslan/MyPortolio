using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
