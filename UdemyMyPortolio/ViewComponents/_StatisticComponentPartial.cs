using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ExperienceCount = portfolioContext.Experiences.Count();
            ViewBag.SkillCount = portfolioContext.Skills.Count();
            ViewBag.PortfolioCount = portfolioContext.Portfolios.Count(); 
            ViewBag.TestimonialCount = portfolioContext.Testimonials.Count();
            return View();


        }
    }
}
