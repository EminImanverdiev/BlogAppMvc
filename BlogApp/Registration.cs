using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace BlogApp
{
    public static class Registration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
			services.AddScoped<IArticleService, ArticleManager>();
			services.AddScoped<IArticleDal, EfArticleDal>();
			services.AddScoped<ICommentService, CommentManager>();
			services.AddScoped<ICommentDal, EfCommentDal>();
		}
    }
}
