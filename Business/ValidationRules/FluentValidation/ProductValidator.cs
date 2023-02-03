using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); // Boş Bırakılamaz
            RuleFor(p => p.ProductName).MinimumLength(2); // min 2 karakter
            RuleFor(p => p.UnitPrice).NotEmpty(); // Boş Bırakılamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0); // 0'dan Büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A Harfi İle Başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
