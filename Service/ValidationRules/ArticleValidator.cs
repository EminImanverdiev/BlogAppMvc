    using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.ArticleTitle).NotEmpty().WithMessage("Blog basliqi bos ola bilmez");
            RuleFor(a=>a.ArticleContent).NotEmpty().WithMessage("Blog mezmunun bos ola bilmez");
            RuleFor(a=>a.ArticleImage).NotEmpty().WithMessage("Blog sekili bos ola bilmez");
        }
    }
}
