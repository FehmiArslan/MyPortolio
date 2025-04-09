using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
