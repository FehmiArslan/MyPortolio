using Microsoft.AspNetCore.Mvc;
using UdemyMyPortolio.DAL.Context;
using UdemyMyPortolio.DAL.Entities;

namespace UdemyMyPortolio.Controllers
{
	public class TestimonialController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Index()
		{
			var values = context.Testimonials.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdateTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			var value = context.Testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult CreateTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			context.Testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var value = context.Testimonials.Find(id);
			context.Testimonials.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}