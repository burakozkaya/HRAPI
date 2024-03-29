﻿using AutoMapper;
using FluentValidation;
using HrApp.Application.CQRS.Advance.Commands;
using HrApp.Application.Helpers;
using HrApp.Application.Interfaces;
using HrApp.Application.Validators;
using HrApp.Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrApp.Application.CQRS.Expense.Commands.Handlers
{
    public class UpdateExpenseCommandHandler : IRequestHandler<UpdateExpenseCommand, ServiceResponse<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUow _uow;
        private readonly IValidator<UpdateExpenseCommand> validator;

        public UpdateExpenseCommandHandler(IMapper mapper, IUow uow, UpdateExpenseValidator validator)
        {
            _mapper = mapper;
            _uow = uow;
            this.validator = validator;
        }

        public async Task<ServiceResponse<int>> Handle(UpdateExpenseCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await validator.ValidateAsync(request);
            if (!validationResult.IsValid)
                return new ServiceResponse<int>(0) { Message = string.Join(" ", validationResult.Errors), IsSuccess = false };
            var entity = _uow.GetExpenseRepository().GetAsync(true, x => x.Id == request.Id).Result;

            entity = _mapper.Map<HrApp.Domain.Entities.Expense>(request);

            //entity.Document = await ImageConversions.ConvertToByteArrayAsync(request.File);

            await _uow.GetExpenseRepository().UpdateAsync(entity);

            await _uow.CommitAsync();

            return new ServiceResponse<int>(entity.Id) { Message = "The expense has been updated successfully", IsSuccess = true };
        }
    }
}
