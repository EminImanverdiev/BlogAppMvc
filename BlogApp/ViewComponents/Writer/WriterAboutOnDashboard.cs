using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApp.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        IWriterService _writerService;

        public WriterAboutOnDashboard(IWriterService writerService)
        {
            _writerService = writerService;
        }
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            AppDbContext dbContext = new AppDbContext();
            var WriterId=dbContext.Writers.Where(x=>x.WriterEmail==usermail)
                .Select(y=>y.WriterId).FirstOrDefault();
            var result= _writerService.GetWriterById(WriterId);
            return View(result);
        }
    }
}
