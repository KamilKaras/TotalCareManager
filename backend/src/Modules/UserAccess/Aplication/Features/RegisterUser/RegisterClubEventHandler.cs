using TotalCareManager.Shared.Messaging.Command;
using TotalCareManager.Shared.Messaging.Events.IntegrationEvents;
using UserAccess.Aplication.Features.RegisterClub;
using UserAccess.Domain.ClubRegistrations.Events;

namespace UserAccess.Aplication.Features.RegisterUser
{
    public class RegisterClubEventHandler : IntegrationEventHandler<ClubRegisterDomainEvent>
    {
        public RegisterClubEventHandler(ICommandBus comandBus) : base(comandBus)
        {
        }

        public async Task Handle(ClubRegisterDomainEvent notification, CancellationToken cancellationToken)
        {
            _comandBus.Execute(
                new RegisterClubCommand(
                1,
                "",
                "",
                ""));
        }
    }
}