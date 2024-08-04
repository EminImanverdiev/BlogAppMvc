using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IArticleService:IGenericService<Article>
	{
		
		List<Article> GetArticlesWithCategory();
		List<Article> GetArticlesByWriter(int Id);
		List<Article> GetArticleById(int Id);
		List<Article> GetLastThreeBlogs();
		List<Article> GetArticlesWithCategoryByWriter(int Id);
		Article GetById(int Id);

    }
}
