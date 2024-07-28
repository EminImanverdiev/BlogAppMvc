using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(w=>w.WriterName)
                .NotEmpty()
                .WithMessage("Yazarin adi soyadi bosh ola bilmez!")
				.MinimumLength(3)
				.WithMessage("En az 3 karakter daxil edin")
			    .MaximumLength(50)
				.WithMessage("Maxsiuymum 50 karakter daxil edin");
			RuleFor(w => w.WriterEmail)
				.NotEmpty()
				.WithMessage("Yazarin Emaili bosh ola bilmez!");
			RuleFor(w => w.WriterPassword)
				.NotEmpty()
				.WithMessage("Sifre bosh ola bilmez!");
		}
    }
}
