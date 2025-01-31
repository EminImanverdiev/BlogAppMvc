﻿using Business.Abstract;
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
            _articleDal.Add(article);
        }

        public List<Article> GetAll()
		{
			return _articleDal.GetAll();	
		}

		public List<Article> GetArticleById(int Id)
		{
			return _articleDal.GetAll(a=>a.ArticleId==Id);
		}
		public List<Article> GetLastThreeBlogs()
		{
			return _articleDal.GetAll().Take(3).ToList();
		}
		public List<Article> GetArticlesByWriter(int Id)
		{
			return _articleDal.GetAll(a=>a.WriterId==Id);
		}

		public List<Article> GetArticlesWithCategory()
		{
			return _articleDal.GetAllWithCategory();
		}

		public Article GetById(int Id)
		{
			return _articleDal.Get(a=>a.ArticleId==Id);
		}

		public void Remove(Article article)
		{
			_articleDal.Delete(article);
		}

		public void Update(Article article)
		{
            _articleDal.Update(article);
        }

        public List<Article> GetArticlesWithCategoryByWriter(int Id)
        {
			return _articleDal.GetAllWithCategoryByWriter(Id);
        }
    }
}
