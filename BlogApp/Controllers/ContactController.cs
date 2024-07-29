using Entities.Concrete;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Xml.Linq;
using System;
using Business.Abstract;

namespace BlogApp.Controllers
{
	public class ContactController : Controller
	{
		IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.ContactDate = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
			contact.ContactStatus = true;
			_contactService.Add(contact);
			return RedirectToAction("Index","Article");
		}

	}
}

