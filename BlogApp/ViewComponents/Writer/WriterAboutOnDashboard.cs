using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

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
            var result= _writerService.GetWriterById(2);
            return View(result);
        }
    }
}
