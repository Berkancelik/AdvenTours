using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public  class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklmasını giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 8 karakterden daha uzun bir isim giriniz");
            

        }

    }
}
