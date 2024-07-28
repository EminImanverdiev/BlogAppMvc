using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Article
{
	public class WriterLastArticle:ViewComponent
	{
		IArticleService _articleService;

		public WriterLastArticle(IArticleService articleService)
		{
			_articleService = articleService;
		}
		public IViewComponentResult Invoke(int Id)
		{
			var result = _articleService.GetArticlesByWriter(Id);
			return View(result);
		}
	}
}
