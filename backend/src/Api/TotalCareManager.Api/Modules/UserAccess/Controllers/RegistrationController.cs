using Microsoft.AspNetCore.Mvc;
using TotalCareManager.Api.Modules.UserAccess.Requests;
using TotalCareManager.Api.Shared.Controllers;
using TotalCareManager.Shared.Messaging.Command.Interfaces;
using UserAccess.Aplication.Features.RegisterCompany;
using UserAccess.Aplication.Features.RegisterUser;

namespace TotalCareManager.Api.Modules.UserAccess.Controllers
{
    [Route("api/userAccess")]
    [ApiController]
    public class RegistrationController : BaseController
    {
        public RegistrationController(ICommandBus commandBus)
            : base(commandBus)
        {
        }

        [HttpPost("register-company")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Guid>> RegisterCompany(CompanyRegisterRequest request)
        {
            var command = new RegisterCompanyCommand(
                request.CompanyTypeId,
                request.NipNumber,
                request.CompanyName,
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
        public async Task<ActionResult<Guid>> RegisterUser(RegisterUserRequest request)
        {
            var command = new RegisterUserCommand(
                request.Name,
                request.Email,
                request.Phone,
                request.CompanyId
                );
            var id = await _commandBus.Execute(command);
            return OkOrNotFound(id);
        }
    }
}