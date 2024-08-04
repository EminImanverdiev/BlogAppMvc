using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Category
{
    public class CategoryListDashboard : ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListDashboard(ICategoryService categoryService)
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
