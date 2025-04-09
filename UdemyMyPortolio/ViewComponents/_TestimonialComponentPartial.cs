using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Testimonials.ToList();
            return View(values);
        }
    }
}