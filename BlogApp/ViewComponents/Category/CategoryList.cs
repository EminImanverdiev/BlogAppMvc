using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		ICategoryService _categoryService;

		public CategoryList(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IViewComponentResult Invoke()
		{
			var result = _categoryService.GetAll();
			return View(result);
		}
	}
}
