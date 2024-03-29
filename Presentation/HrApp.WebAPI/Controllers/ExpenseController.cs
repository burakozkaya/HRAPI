﻿using HrApp.Application.CQRS.Advance.Commands;
using HrApp.Application.CQRS.Expense.Commands;
using HrApp.Application.CQRS.Expense.Queries;
using HrApp.Application.CQRS.ExpenseType.Queries;
using HrApp.Application.Wrappers;
using HrApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<Expense> _logger;

        public ExpenseController(IMediator mediator, ILogger<Expense> logger)
        {
            this.mediator = mediator;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Get(int? id)
        {
            var result = await mediator.Send(new ReadAllExpenseQuery() { companyId = id });
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("Types")]
        public async Task<IActionResult> GetTypes()
        {
            var result = await mediator.Send(new ReadAllExpenseTypeQuery());
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await mediator.Send(new ReadExpenseQuery(id));
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateExpenseCommand command)
        {
            var result = await mediator.Send(command);
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateExpenseCommand command)
        {
            var result = await mediator.Send(command);
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await mediator.Send(new DeleteExpenseCommand(id));
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("Approve")]
        public async Task<IActionResult> Approve(int id, bool isApproved)
        {
            var result = await mediator.Send(new ApproveExpenseCommand() { Id = id, IsApproved = isApproved });
            if (result.IsSuccess) { return Ok(result); }
            return BadRequest(result);
        }
    }
}
