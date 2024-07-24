using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
