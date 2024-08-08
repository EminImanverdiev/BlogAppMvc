using BlogApp.Models;
using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace BlogApp.Controllers
{
	public class WriterController : Controller
	{
        IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        [Authorize]
        public IActionResult Index()
		{
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
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
            AppDbContext dbContext = new AppDbContext();
            var usermail = User.Identity.Name;
            var WriterId = dbContext.Writers.Where(x => x.WriterEmail == usermail)
               .Select(y => y.WriterId).FirstOrDefault();
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
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddProfileImage writer)
        {
            Writer w = new Writer();
            if (writer.WriterImage!=null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newimagename=Guid.NewGuid()+extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/",newimagename);
                var stream= new FileStream(location,FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterEmail= writer.WriterEmail;
            w.WriterPassword= writer.WriterPassword;
            w.WriterName= writer.WriterName;
            w.WriterStatus= writer.WriterStatus;
            w.WriterAbout= writer.WriterAbout;
            _writerService.Add(w);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
