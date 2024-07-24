using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
