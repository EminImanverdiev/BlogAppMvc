using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        IMessageService _messageService;

        public WriterMessageNotification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            string p;
            p = "dev.studio@mail.az";
            var result = _messageService.GetInboxListByWriter(p);
            return View(result);
        }
    }
}
