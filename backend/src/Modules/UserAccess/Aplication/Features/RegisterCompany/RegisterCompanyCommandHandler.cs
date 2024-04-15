using TotalCareManager.Shared.Messaging.Command.Implementations;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Aplication.Repositories.CompanyRegistrations;
using UserAccess.Domain.Companies.Entities;
using UserAccess.Domain.Companies.Enumerations;
using UserAccess.Domain.Companies.ValueObjects;

namespace UserAccess.Aplication.Features.RegisterCompany
{
    internal sealed class RegisterCompanyCommandHandler : CommandHandler<RegisterCompanyCommand, Guid>
    {
        private readonly ICompanyRegistrationRepository _repository;

        public RegisterCompanyCommandHandler(ICompanyRegistrationRepository repository)
        {
            _repository = repository;
        }

        protected override async Task<Guid> Handle(RegisterCompanyCommand command)
        {
            var name = new CompanyName(command.CompanyName);
            var type = CompanyType.FromId(command.CompanyTypeId);
            var nip = new Nip(command.Nip);

            var newClub = new CompanyRegistration(
                name,
                nip,
                type
                );

            await _repository.AddAsync(newClub);

            return newClub.Id.Value;
        }
    }
}