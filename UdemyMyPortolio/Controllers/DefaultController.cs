using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
