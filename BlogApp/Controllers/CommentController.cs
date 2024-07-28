using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

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
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment comment)
		{
			comment.CommentDate = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
			comment.CommentStatus = true;
			comment.ArticleId = 3;
			_commentService.Add(comment);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int Id)
		{
			var result=_commentService.GetList(Id);
			return PartialView(result);
		}
	}
}
