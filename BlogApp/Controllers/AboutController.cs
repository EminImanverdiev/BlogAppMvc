using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class AboutController : Controller
	{
		IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IActionResult Index()
		{
			var result = _aboutService.GetAll();
			return View(result);
		}
		[HttpGet]
		public PartialViewResult SosialMediaAbout()
		{
			return PartialView();
		}
	}
}
