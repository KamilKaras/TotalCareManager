using TotalCareManager.Shared.Messaging;

namespace UserAccess.Aplication.Features.RegisterGroup
{
    internal sealed class RegisterGroupCommandHandler : CommandHandler<RegisterGroupCommand, int>
    {
        protected override async Task<int> Handle(RegisterGroupCommand command)
        {
            return 10;
        }
    }
}