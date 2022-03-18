using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz....!");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama giriniz..!");
            RuleFor(x => x.Image).MaximumLength(150).WithMessage("Lütfen Açıklamayı okuyunuz...");

        }
    }
}
