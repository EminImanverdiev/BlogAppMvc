using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfArticleDal : EfEntityRepositoryBase<Article, AppDbContext>, IArticleDal
	{
		public List<Article> GetAllWithCategory()
		{
			using var context = new AppDbContext();
			return context.Articles.Include(c => c.Category).ToList();
		}
	}

}
