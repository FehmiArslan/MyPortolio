using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolioContext PortfolioContext = new PortfolioContext();   
        public IViewComponentResult Invoke()
        {
            var values=PortfolioContext.Features.ToList();
            return View(values);
        }
    }
}
