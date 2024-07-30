using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
        List<Article> GetAllWithCategory();
        List<Article> GetAllWithCategoryByWriter(int Id);
    }

}
