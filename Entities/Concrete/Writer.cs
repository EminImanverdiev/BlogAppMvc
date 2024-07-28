using Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Writer : IEntity
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
		public List<Article> Articles { get; set; }

	}
}
