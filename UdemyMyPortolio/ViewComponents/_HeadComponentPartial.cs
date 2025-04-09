using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortolio.ViewComponents
{
    public class _HeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
