using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BlogApp.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        ISecondMessageService _secondMessageService;

        public MessageController(ISecondMessageService secondMessageService)
        {
            _secondMessageService = secondMessageService;
        }

        public IActionResult InBox()
        {
            int id = 2;
            var result = _secondMessageService.GetInboxListByWriter(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult MessageDetails(int Id)
        {
           var result=_secondMessageService.GetById(Id);
            return View(result);
        }

    }
}
