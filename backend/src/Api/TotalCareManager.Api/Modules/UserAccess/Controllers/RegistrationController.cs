using Microsoft.AspNetCore.Mvc;
using TotalCareManager.Api.Modules.UserAccess.Requests;
using TotalCareManager.Api.Shared.Controllers;
using TotalCareManager.Shared.Messaging;
using UserAccess.Aplication.Features.RegisterGroup;
using UserAccess.Aplication.Features.RegisterUser;

namespace TotalCareManager.Api.Modules.UserAccess.Controllers
{
    [Route("api/userAccess")]
    [ApiController]
    public class RegistrationController : BaseController
    {
        public RegistrationController(ICommandBus commandBus) : base(commandBus)
        {
        }

        [HttpPost("register-user")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<int>> RegisterUser(RegisterUserRequest request)
        {
            var command = new RegisterUserCommand(
                request.Name,
                request.Email,
                request.Phone
                );
            var id = await _commandBus.Execute(command);
            return OkOrNotFound(id);
        }

        [HttpPost("register-group")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<int>> RegisterGroup(GroupRegisterRequest request)
        {
            var command = new RegisterGroupCommand(
                request.GroupName,
                request.NipNumber,
                request.CompanyName,
                request.Name,
                request.Email,
                request.Phone
                );
            var id = await _commandBus.Execute(command);
            return OkOrNotFound(id);
        }
    }
}