using MediatR;
using Microsoft.AspNetCore.Mvc;
using FurnitureRetail.Core;
using FurnitureRetail.Core.Queries;

namespace FurnitureRetail.API.Controllers;

public class ProductsController : ApiController
{
    public ProductsController(IMediator mediator) : base(mediator) { }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Products>>> GetAll()
    {
        var result = await Mediator.Send(new ProductsListQuery());

        return FromResult(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductModel>> Get(Guid id)
    {
        var result = await Mediator.Send(new ProductByIdQuery { Id = id });

        return FromResult(result);
    }


    [HttpPost]
    [ProducesResponseType(201)]
    public async Task<ActionResult<ProductModel>> Create([FromBody] CreateProductCommand command)
    {
        var result = await Mediator.Send(command);
        return CreatedResult(result, nameof(Get), new { id = result.Value.Id });
    }
}