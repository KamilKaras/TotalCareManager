using MediatR;
using TotalCareManager.Shared.Messaging.Command.Interfaces;
using UserAccess.Aplication.Features.RegisterUser;
using UserAccess.Domain.ClubRegistrations.Events;

namespace UserAccess.Aplication.Features.RegisterClub
{
    public sealed class ClubRegisteredIntegrationEventHandler : INotificationHandler<ClubRegisteredDomainEvent>
    {
        private readonly ICommandBus _comandBus;

        public ClubRegisteredIntegrationEventHandler(ICommandBus comandBus)
        {
            _comandBus = comandBus;
        }

        public async Task Handle(ClubRegisteredDomainEvent notification, CancellationToken cancellationToken)
        {
            await _comandBus.Execute(new RegisterUserCommand("", "", ""));
        }
    }
}