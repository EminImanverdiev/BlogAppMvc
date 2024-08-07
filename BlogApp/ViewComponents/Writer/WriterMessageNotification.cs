using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        ISecondMessageService _messageService;

        public WriterMessageNotification(ISecondMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            int Id = 2;
            var result = _messageService.GetInboxListByWriter(Id);
            return View(result);
        }
    }
}
