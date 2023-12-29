﻿using FluentValidation;
using HrApp.Application.CQRS.Expense.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Application.Validators
{
    internal class UpdateExpenseValidator : AbstractValidator<UpdateExpenseCommand>
    {

        public UpdateExpenseValidator()
        {
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(1).WithMessage("Amount must be greater then 0.");
            RuleFor(x => x.CurrencyId).NotEmpty().WithMessage("Currency is required");
            RuleFor(x => x.ExpenseTypeId).NotEmpty().WithMessage("Expense Type is required");
            RuleFor(x => x.Document).NotEmpty().WithMessage("File is required");

        }
    }
}
