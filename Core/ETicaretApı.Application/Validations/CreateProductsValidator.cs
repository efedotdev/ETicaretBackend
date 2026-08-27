using ETicaretApı.Application.ViewModules.Products;
using FluentValidation;

namespace ETicaretApı.Application.Validations;

public class CreateProductsValidator : AbstractValidator<VM_Create_Product>
{
    public CreateProductsValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .Length(5,100)
            .WithMessage("5 ile 100 karakter arasında bir isim giriniz lütfen.");
        RuleFor(x => x.Stock)
            .NotEmpty()
            .NotNull()
            .GreaterThan(-1)
            .WithMessage("Stok boş bırakılmamalı ve en az 0 girilmelidir.");
        RuleFor(x => x.Price)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0)
            .WithMessage("Fiyat boş bırakılmamalı ve 0 dan büyük olmalıdır. ");
    }
}