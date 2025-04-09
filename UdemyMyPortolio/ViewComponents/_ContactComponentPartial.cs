using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyMyPortolio.DAL.Context;

namespace UdemyMyPortolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var contact = portfolioContext.Contacts.FirstOrDefault();
            ViewBag.phone1 = contact.Phone1;
            ViewBag.phone2 = contact.Phone2;
            ViewBag.email1 = contact.Email1;
            ViewBag.email2 = contact.Email2;
            ViewBag.adress = contact.Address;
            ViewBag.title = contact.Title;
            ViewBag.description = contact.Description;
            return View();
        }
    }
}
