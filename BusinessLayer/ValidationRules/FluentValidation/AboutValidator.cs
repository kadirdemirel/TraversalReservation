using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz...");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik açıklama bilgisi giriniz...");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakterlik açıklama bilgisi giriniz...");
        }
    }
}
