using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void Add(Comment comment)
		{
			_commentDal.Add(comment);
		}

		public List<Comment> GetAll()
		{
			return _commentDal.GetAll();
		}

		public List<Comment> GetList(int Id)
		{
			return _commentDal.GetAll(c=>c.ArticleId==Id);
		}
	}
}
