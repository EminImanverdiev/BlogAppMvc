using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApp.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            using (AppDbContext context=new AppDbContext())
            {
                ViewBag.v1=context.Articles.Count().ToString();
                ViewBag.v2=context.Articles.Where(x=>x.WriterId==1).Count();
                ViewBag.v3=context.Categorys.Count();

            }
            return View();
        }
    }
}
