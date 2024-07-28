using Business.Abstract;
using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class RegisterController : Controller
	{
		IWriterService _writerService;

		public RegisterController(IWriterService writerService)
		{
			_writerService = writerService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator validator = new WriterValidator();
			ValidationResult results= validator.Validate(writer);
            if (results.IsValid)
            {
				writer.WriterStatus = true;
				writer.WriterAbout = "Test";
				_writerService.Add(writer);
				return RedirectToAction("Index", "Article");
			}
			else
			{
                foreach (var item in results.Errors)
                {
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
			return View();
            
		}
	}
}
