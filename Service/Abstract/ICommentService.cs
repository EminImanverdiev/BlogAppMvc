using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface ICommentService
	{
		void Add(Comment comment);
		//void Remove(Comment comment);
		//void Update(Comment comment);
		List<Comment> GetAll();
		//Comment GetById(int Id);
		List<Comment> GetList(int Id);
	}
}
