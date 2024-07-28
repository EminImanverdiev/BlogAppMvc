using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IArticleService
	{
		void Add(Article article);
		void Remove(Article article);
		void Update(Article article);
		List<Article> GetAll();
		Article GetById(int Id);
		List<Article> GetArticlesWithCategory();
		List<Article> GetArticlesByWriter(int Id);
		List<Article> GetArticleById(int Id);

	}
}
