using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortolio.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
