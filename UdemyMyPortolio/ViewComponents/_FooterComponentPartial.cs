using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.SocialMedias.ToList();
            return View(values);

        }
    }
}
