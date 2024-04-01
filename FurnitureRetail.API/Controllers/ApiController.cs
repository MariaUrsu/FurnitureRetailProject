using MediatR;
using Microsoft.AspNetCore.Mvc;
using FurnitureRetail.Core;

namespace FurnitureRetail.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        protected readonly IMediator Mediator;

        
        public ApiController(IMediator  mediator)
        {
            Mediator = mediator;
        }

        protected ActionResult<TModel> FromResult<TModel>(Result<TModel> result)
        {
            if (result.Status != ResultStatus.Success)
            {
                return Fail(result);
            }

            return result.Value;
        }

        protected ActionResult FromResult(Result result)
        {
            if (result.Status != ResultStatus.Success)
            {
                return Fail(result);
            }

            return Ok();
        }

        protected ActionResult<TModel> CreatedResult<TModel>(Result<TModel> result,
            string actionName,
            object routeValues)
        {
            if (result.Status != ResultStatus.Success)
            {
                return Fail(result);
            }

            return CreatedAtAction(actionName, routeValues, result.Value);
        }

        protected ActionResult Fail<TItem>(Result<TItem> result)
        {
            return ComputeFailType(result.Status, result.Errors);
        }

        private ActionResult Fail(Result result)
        {
            return ComputeFailType(result.Status, result.Errors);
        }

        private ActionResult ComputeFailType(ResultStatus status, IReadOnlyCollection<string> errors)
        {
            if (status == ResultStatus.NotPresent)
            {
                if (errors.Any())
                {
                    return NotFound(new
                    {
                        value = errors
                    });
                }

                return NotFound();
            }

            if (status == ResultStatus.Forbidden)
            {
                return Forbid();
            }

            if (status == ResultStatus.NotAuthorized)
            {
                return Unauthorized();
            }

            if (status == ResultStatus.InvalidOperation)
            {
                return BadRequest(new
                {
                    value = errors
                });
            }

            return null;
        }
    }
}
