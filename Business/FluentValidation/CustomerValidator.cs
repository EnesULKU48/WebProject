using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity.Concrete;

using FluentValidation;

namespace Business.FluentValidation
{
	public class CustomerValidator:AbstractValidator<Customer>
	{
		public CustomerValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim boş geçilemez!");
			RuleFor(x => x.City).NotEmpty().WithMessage("Şehir boş geçilemez!");
		}
	}
}
