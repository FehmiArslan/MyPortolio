using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
