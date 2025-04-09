using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(y=>y.SubDescription).FirstOrDefault();
            ViewBag.aboutdetail=portfolioContext.Abouts.Select(y=>y.Details).FirstOrDefault();
            return View();
        }
    }
}
