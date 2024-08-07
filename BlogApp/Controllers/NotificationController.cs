using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class NotificationController : Controller
    {
        INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var result = _notificationService.GetAll();
            return View(result);
        }
    }
}
