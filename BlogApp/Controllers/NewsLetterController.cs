using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class NewsLetterController : Controller
	{
		INewsLetterService _newsletterService;

		public NewsLetterController(INewsLetterService newsletterService)
		{
			_newsletterService = newsletterService;
		}

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			_newsletterService.Add(newsLetter);
			return PartialView();
		}
	}
}
