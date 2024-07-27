using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
