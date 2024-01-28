using Microsoft.AspNetCore.Mvc;
using TotalCareManager.Api.Modules.UserAccess.Requests;
using TotalCareManager.Api.Shared.Controllers;
using TotalCareManager.Shared.Messaging.Command;
using TotalCareManager.Shared.Messaging.Query;
using UserAccess.Aplication.Features.RegisterClub;
using UserAccess.Aplication.Features.RegisterUser;

namespace TotalCareManager.Api.Modules.UserAccess.Controllers
{
    [Route("api/userAccess")]
    [ApiController]
    public class RegistrationController : BaseController
    {
        public RegistrationController(ICommandBus commandBus, IQueryBus queryBus)
            : base(commandBus, queryBus)
        {
        }

        [HttpPost("register-club")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Guid>> RegisterClub(ClubRegisterRequest request)
        {
            var command = new RegisterClubCommand(
                request.ClubTypeId,
                request.UserName,
                request.UserEmail,
                request.UserPhone
                );
            var id = await _commandBus.Execute(command);
            return OkOrNotFound(id);
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
    }
}