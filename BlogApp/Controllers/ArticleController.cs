using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class ArticleController : Controller
    {
        IArticleService _articleService;

		public ArticleController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IActionResult Index()
        {
            var result=_articleService.GetAll();
            return View(result);
        }
    }
}
