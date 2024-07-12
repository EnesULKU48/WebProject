using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity.Concrete;

using FluentValidation;

namespace Business.FluentValidation
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(x=>x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
			RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalı!");
			RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez!");
			RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez!");
		}
	}
}
