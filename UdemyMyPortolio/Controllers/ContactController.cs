using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;
using UdemyMyPortolio.DAL.Entities;

namespace UdemyMyPortolio.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
