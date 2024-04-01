using MediatR;
using Microsoft.AspNetCore.Mvc;
using FurnitureRetail.Core;
using FurnitureRetail.Core.Queries;

namespace FurnitureRetail.API.Controllers;

public class CustomersController : ApiController
{
    public CustomersController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Customers>>> GetAll()
    {
        var result = await Mediator.Send(new CustomerListQuery());

        return FromResult(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CustomerModel>> Get(Guid id)
    {
        var result = await Mediator.Send(new CustomerByIdQuery { Id = id });

        return FromResult(result);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    public async Task<ActionResult<CustomerModel>> Create([FromBody] CreateCustomerCommand command)
    {
        var result = await Mediator.Send(command);
        return CreatedResult(result, nameof(Get), new { id = result.Value.Id });
    }
}