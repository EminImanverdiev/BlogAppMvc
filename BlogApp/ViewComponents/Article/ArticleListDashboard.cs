using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Article
{
    public class ArticleListDashboard:ViewComponent

    {
        IArticleService _articleService;

        public ArticleListDashboard(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _articleService.GetArticlesWithCategory();
            return View(result);
        }
    }
}
