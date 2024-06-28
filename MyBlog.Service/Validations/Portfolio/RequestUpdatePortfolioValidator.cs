using FluentValidation;
using MyBlog.Core.DTOs.Request.Portfolio;

namespace MyBlog.Services.Validations.Portfolio;

public class RequestUpdatePortfolioValidator:AbstractValidator<RequestUpdatePortfolio>
{
    public RequestUpdatePortfolioValidator()
    {
        RuleFor(p => p.Id).NotEmpty().WithMessage("Id boş olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Proje İsmi Null olamaz").NotEmpty().WithMessage("Proje İsmi Boş Olamaz");
        RuleFor(p => p.ImageUrl).NotNull().WithMessage("ImageUrl Alanı Null Olamaz").NotEmpty().WithMessage("ImageUrl Alanı Boş Olamaz");
        RuleFor(p => p.ImageUrl2).NotNull().WithMessage("ImageUrl2 Alanı Null Olamaz").NotEmpty().WithMessage("ImageUrl2 Alanı Boş Olamaz");
        RuleFor(p => p.Price).NotNull().WithMessage("Price Alanı Null Olamaz").NotEmpty().WithMessage("Price Alanı Boş Olamaz");
        RuleFor(p => p.Value).NotNull().WithMessage("Oran Alanı Null Olamaz").NotEmpty().WithMessage("Oran Alanı Boş Olamaz");
    }
}