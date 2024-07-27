using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Comment
{
	public class CommentListByArticle:ViewComponent
	{
		ICommentService _commentService;

		public CommentListByArticle(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IViewComponentResult Invoke(int Id)
		{
			var result = _commentService.GetList(Id);
			return View(result);
		}
	}
}
