﻿using System;
using System.Globalization;
using FluentValidation;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
           ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");

            RuleFor(m => m.FirstName).NotEmpty().WithMessage("not be empty");
            RuleFor(m => m.LastName).NotEmpty().WithMessage("not be empty");
            RuleFor(m => m.DateOfBirth).NotEmpty().WithMessage("not be empty");
            RuleFor(m => m.TcNo).NotEmpty().WithMessage("not be empty");
            RuleFor(m => m.Email).NotEmpty().WithMessage("not be empty");

            RuleFor(m => m.Email).EmailAddress().WithMessage("must be email");
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now).WithMessage("must be an old date");
            RuleFor(m => m.TcNo).Length(11).WithMessage("must be 11 length");
            RuleFor(m => m.DateOfBirth).Must(BeAValidDate).WithMessage("Start date is required");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
