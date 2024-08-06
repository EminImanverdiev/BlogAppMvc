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
			services.AddScoped<IWriterService, WriterManager>();
			services.AddScoped<IWriterDal, EfWriterDal>();
			services.AddScoped<INewsLetterService, NewsLetterManager>();
			services.AddScoped<INewsLetterDal, EfNewsLetterDal>();
			services.AddScoped<IAboutDal, EfAboutDal>();
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IContactDal, EfContactDal>();
			services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<INotificationDal, EfNotificationDal>();
            services.AddScoped<INotificationService, NotificationManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();
            services.AddScoped<IMessageService, MessageManager>();
        }
    }
}
