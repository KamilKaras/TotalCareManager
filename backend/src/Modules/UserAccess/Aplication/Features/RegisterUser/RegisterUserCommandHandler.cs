using TotalCareManager.Shared.Messaging.Command;

namespace UserAccess.Aplication.Features.RegisterUser
{
    internal sealed class RegisterUserCommandHandler : CommandHandler<RegisterUserCommand, int>
    {
        protected override async Task<int> Handle(RegisterUserCommand command)
        {
            return 11;
        }
    }
}