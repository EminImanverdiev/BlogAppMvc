using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogApp.Controllers
{
    public class ArticleController : Controller
    {
        IArticleService _articleService;
        ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService = null)
        {
            _articleService = articleService;
            _categoryService = categoryService;
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
            var usermail = User.Identity.Name;
            AppDbContext dbContext = new AppDbContext();
            var WriterId = dbContext.Writers.Where(x => x.WriterEmail == usermail)
                .Select(y => y.WriterId).FirstOrDefault();
            var result=_articleService.GetArticlesWithCategoryByWriter(WriterId);
            return View(result);  
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> categoryValues = _categoryService.GetAll()
                .Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.CV = categoryValues;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Article article)
        {
            var usermail = User.Identity.Name;
            AppDbContext dbContext = new AppDbContext();
            var WriterId = dbContext.Writers.Where(x => x.WriterEmail == usermail)
                .Select(y => y.WriterId).FirstOrDefault();
            ArticleValidator validator = new ArticleValidator();
            ValidationResult results = validator.Validate(article);
            if (results.IsValid)
            {
                article.ArticleStatus = true;
                article.ArticleCreateDate = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
                article.WriterId = WriterId;
                _articleService.Add(article);
                return RedirectToAction("ArticleListByWriter", "Article");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                List<SelectListItem> categoryValues = _categoryService.GetAll()
                    .Select(x => new SelectListItem
                    {
                        Text = x.CategoryName,
                        Value = x.CategoryId.ToString()
                    }).ToList();
                ViewBag.CV = categoryValues;
            }
            return View();
        }

        public IActionResult Delete(int Id)
        {
            var result=_articleService.GetById(Id);
            _articleService.Remove(result);
            return RedirectToAction("ArticleListByWriter", "Article");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            List<SelectListItem> categoryValues = _categoryService.GetAll()
                .Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.CV = categoryValues;

            var result = _articleService.GetById(Id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result); 
        }

        [HttpPost]
        public IActionResult Edit(Article article)
        {
            var usermail = User.Identity.Name;
            AppDbContext dbContext = new AppDbContext();
            var WriterId = dbContext.Writers.Where(x => x.WriterEmail == usermail)
                .Select(y => y.WriterId).FirstOrDefault();
            article.WriterId = WriterId;
            article.ArticleStatus = true;
            article.ArticleCreateDate = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
            _articleService.Update(article);
            return RedirectToAction("ArticleListByWriter");
        }
    }
}
