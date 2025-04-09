using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        PortfolioContext PortfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = PortfolioContext.Portfolios.ToList();
            return View(values);
        }
    }
}
