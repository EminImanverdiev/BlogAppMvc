using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
