using Business.Abstract;
using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult ArticleListByWriter() {
           var result=_articleService.GetArticlesByWriter(2);
            return View(result);  
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Article article) 
        {
            ArticleValidator validator = new ArticleValidator();
            ValidationResult results = validator.Validate(article);
            if (results.IsValid)
            {
                article.ArticleStatus = true;
                article.ArticleCreateDate = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
                article.ArticleId = 1;
                _articleService.Add(article);
                return RedirectToAction("ArticleListByWriter", "Article");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
