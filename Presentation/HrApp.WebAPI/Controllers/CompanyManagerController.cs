using HrApp.Application;
using HrApp.Application.CQRS.AppUser.Commands;
using HrApp.Application.CQRS.AppUser.Queries;
using HrApp.Application.CQRS.Company.Commands;
using HrApp.Application.CQRS.Company.Queries;
using HrApp.Application.CQRS.CompanyType.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HrApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyManagerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CompanyManagerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllAppUserQuery() );
            if (result.IsSuccess) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _mediator.Send(new GetAppUserQuery(id));
            if (result.IsSuccess) { return Ok(result); }
            return BadRequest(result);
        }



        [HttpPost]
        public async Task<IActionResult> Add(AddAppUserCommand addAppUserCommand)
        {
            var result = await _mediator.Send(addAppUserCommand);
            if (result.IsSuccess) { return Ok(result); }
            return BadRequest(result);
        }

    }
}
