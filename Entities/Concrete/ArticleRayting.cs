using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ArticleRayting:IEntity
    {
        public int ArticleRaytingId { get; set; }
        public int ArticleId { get; set; }
        public int ArticleTotalScore { get; set; }
        public int ArticleRaytingCount { get; set; }
    }
}
