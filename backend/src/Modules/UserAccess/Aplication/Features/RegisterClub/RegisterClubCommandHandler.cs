using TotalCareManager.Shared.Messaging.Command.Implementations;
using UserAccess.Aplication.Repositories;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Aplication.Features.RegisterClub
{
    internal sealed class RegisterClubCommandHandler : CommandHandler<RegisterClubCommand, Guid>
    {
        private readonly IClubRegistrationRepository _repository;

        public RegisterClubCommandHandler(IClubRegistrationRepository repository)
        {
            _repository = repository;
        }

        protected override async Task<Guid> Handle(RegisterClubCommand command)
        {
            var newClub = new ClubRegistration(
                "",
                "",
                ""
                );
            await _repository.AddAsync(newClub);
            return newClub.Id.Value;
        }
    }
}