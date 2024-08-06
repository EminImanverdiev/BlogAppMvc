using Business.Abstract;
using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogApp.Controllers
{
    [AllowAnonymous]
	public class WriterController : Controller
	{
        IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
        [AllowAnonymous]

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile() 
        { 
            var result=_writerService.GetById(2);
            return View(result);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult results = validator.Validate(writer);
            if (results.IsValid)
            {
                _writerService.Update(writer);
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                foreach (var result in results.Errors)
                {
                    ModelState.AddModelError(result.PropertyName,result.ErrorMessage);
                }
            }
            return View();
        }
    }
}
