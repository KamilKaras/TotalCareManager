using Microsoft.AspNetCore.Mvc;
using TotalCareManager.Shared.Messaging.Command;
using TotalCareManager.Shared.Messaging.Query;

namespace TotalCareManager.Api.Shared.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly ICommandBus _commandBus;
        protected readonly IQueryBus _queryBus;

        protected BaseController(ICommandBus commandBus, IQueryBus _queryBus)
        {
            _commandBus = commandBus;
            this._queryBus = _queryBus;
        }

        protected ActionResult<IActionResult> OkOrNotFound<IActionResult>(IActionResult result)
            => result is null ? NotFound() : Ok(result);
    }
}