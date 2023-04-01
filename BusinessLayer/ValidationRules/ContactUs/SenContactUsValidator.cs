﻿using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SenContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SenContactUsValidator() {

            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");

            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına minimum 5 karakter girişi yapınız!");
            RuleFor(x => x.Subject).MaximumLength(150).WithMessage("Konu alanına maximum 150 karakter girişi yapınız!");


            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanına minimum 5 karakter girişi yapınız!");
            RuleFor(x => x.Mail).MaximumLength(150).WithMessage("Mail alanına maximum 150 karakter girişi yapınız!");
        }
    }
}