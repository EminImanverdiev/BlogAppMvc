using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Article
{
	public class ArticleLastThreePosts:ViewComponent
	{
		IArticleService _articleService;

		public ArticleLastThreePosts(IArticleService articleService)
		{
			_articleService = articleService;
		}
		public IViewComponentResult Invoke()
		{
			var result=_articleService.GetLastThreeBlogs();
			return View(result);
		}
	}
}
