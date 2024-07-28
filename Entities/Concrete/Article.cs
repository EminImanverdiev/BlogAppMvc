using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Article : IEntity
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public string ArticleThumbnailImage { get; set; }
        public string ArticleImage { get; set; }
        public DateTime ArticleCreateDate { get; set; }
        public bool ArticleStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
		public int WriterId { get; set; }
		public Writer Writer { get; set; }
		public ICollection<Comment> Comments { get; set; }
	}

}
