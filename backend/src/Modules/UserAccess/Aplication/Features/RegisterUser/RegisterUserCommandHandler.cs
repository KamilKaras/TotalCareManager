using TotalCareManager.Shared.Messaging.Command.Implementations;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Aplication.Repositories.UserRegistrations;
using UserAccess.Domain.Companies.Entities;
using UserAccess.Domain.UserRegistrations.Entities;
using UserAccess.Domain.UserRegistrations.ValueObjects;

namespace UserAccess.Aplication.Features.RegisterUser
{
    internal sealed class RegisterUserCommandHandler : CommandHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRegistrationRepository _userRepository;

        public RegisterUserCommandHandler(IUserRegistrationRepository userRepository)
        {
            _userRepository = userRepository;
        }

        protected override async Task<Guid> Handle(RegisterUserCommand command)
        {
            var name = new UserName(command.Name);
            var phone = new Phone(command.Phone);
            var email = new Email(command.Email);
            var companyId = new CompanyRegistrationId(Guid.Parse(command.CompanyId));

            var user = new UserRegistration(
                name,
                email,
                phone,
                companyId
                );

            await _userRepository.AddAsync(user);

            return user.Id.Value;
        }
    }
}