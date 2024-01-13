using TotalCareManager.Shared.Messaging;
using UserAccess.Domain.Clubs.Entities;
using UserAccess.Domain.Clubs.Enumerations;
using UserAccess.Domain.Users.Entities;

namespace UserAccess.Aplication.Features.RegisterGroup
{
    internal sealed class RegisterClubCommandHandler : CommandHandler<RegisterClubCommand, Guid>
    {
        protected override async Task<Guid> Handle(RegisterClubCommand command)
        {
            var newUser = new User(
                command.UserName,
                command.UserEmail,
                command.UserPhone,
                "testPassword"
                );

            var newClub = new Club(
                command.ClubName,
                ClubType.FromId(command.ClubTypeId)
                );

            return newClub.Id.Value;
        }
    }
}