﻿using TotalCareManager.Shared.Messaging.Command;
using UserAccess.Domain.ClubRegistrations.Entities;
using UserAccess.Domain.ClubRegistrations.Enumerations;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Aplication.Features.RegisterClub
{
    internal sealed class RegisterClubCommandHandler : CommandHandler<RegisterClubCommand, Guid>
    {
        protected override async Task<Guid> Handle(RegisterClubCommand command)
        {
            var newUser = new UserRegistration(
                command.UserName,
                command.UserEmail,
                command.UserPhone,
                "testPassword"
                );

            var newClub = new ClubRegistration(
                command.ClubName,
                command.NipNumber,
                ClubType.FromId(command.ClubTypeId)
                );

            return newClub.Id.Value;
        }
    }
}