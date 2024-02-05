using TotalCareManager.Shared.Messaging.Command.Implementations;
using UserAccess.Domain.ClubRegistrations.Entities;
using UserAccess.Domain.ClubRegistrations.Enumerations;

namespace UserAccess.Aplication.Features.RegisterClub
{
    internal sealed class RegisterClubCommandHandler : CommandHandler<RegisterClubCommand, Guid>
    {
        protected override async Task<Guid> Handle(RegisterClubCommand command)
        {
            var newClub = new ClubRegistration(
                "",
                "",
                ClubType.FromId(command.ClubTypeId)
                );

            return newClub.Id.Value;
        }
    }
}