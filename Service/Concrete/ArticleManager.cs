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
	public class ArticleManager : IArticleService
	{
		IArticleDal _articleDal;

		public ArticleManager(IArticleDal articleDal)
		{
			_articleDal = articleDal;
		}

		public void Add(Article article)
		{
			throw new NotImplementedException();
		}

		public List<Article> GetAll()
		{
			return _articleDal.GetAll();	
		}

		public Article GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public void Remove(Article article)
		{
			throw new NotImplementedException();
		}

		public void Update(Article article)
		{
			throw new NotImplementedException();
		}
	}
}
