﻿using Business.Models.BaseDTO;
using FluentValidation;

namespace Business.Validators
{
    public class GenderValidator : AbstractValidator<GenderDto>
    {
        public GenderValidator()
        {
            RuleFor(x => x.Description).NotNull().Length(1, 6);
        }
    }
}