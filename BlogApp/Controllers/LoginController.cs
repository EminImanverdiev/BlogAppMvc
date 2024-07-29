using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer writer)
		{
			AppDbContext context = new AppDbContext();
			var datavalues = context.Writers.FirstOrDefault(w => w.WriterEmail == writer.WriterEmail && w.WriterPassword == writer.WriterPassword);
            if (datavalues!=null)
            {
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,writer.WriterEmail)
				};
				var useridentity=new ClaimsIdentity(claims,"N");
				ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(claimsPrincipal);
				return RedirectToAction("Index", "Writer"); 
            }
			else
			{
				return View();
			}
        }
	}
}
//AppDbContext context = new AppDbContext();
//var datavalues = context.Writers.FirstOrDefault(w => w.WriterEmail == writer.WriterEmail && w.WriterPassword == writer.WriterPassword);
//if (datavalues != null)
//{
//	HttpContext.Session.SetString("username", writer.WriterEmail);
//	return RedirectToAction("Index", "Writer");
//}
//else
//{
//	return View();
//}