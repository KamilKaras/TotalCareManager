﻿using Microsoft.AspNetCore.Mvc;
using TotalCareManager.Shared.Messaging.Command.Interfaces;
using TotalCareManager.Shared.Messaging.Query;

namespace TotalCareManager.Api.Shared.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly ICommandBus _commandBus;

        protected BaseController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        protected ActionResult<IActionResult> OkOrNotFound<IActionResult>(IActionResult result)
            => result is null ? NotFound() : Ok(result);
    }
}