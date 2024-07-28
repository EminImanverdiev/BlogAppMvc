using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
