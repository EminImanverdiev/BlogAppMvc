using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class LoginController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
