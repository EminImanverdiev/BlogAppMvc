using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        IArticleService _articleService;

		public ArticleController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IActionResult Index()
        {
            var result=_articleService.GetArticlesWithCategory();
            return View(result);
        }
        public IActionResult ArticleDetail(int id) {
            ViewBag.Id = id;
            var result=_articleService.GetArticleById(id);
            return View(result);
        }
    }
}
