using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
