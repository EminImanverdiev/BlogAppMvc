using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
	public class CommentController : Controller
	{
		ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int Id)
		{
			var result=_commentService.GetList(Id);
			return PartialView(result);
		}
	}
}
