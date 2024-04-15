using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace UserAccess.Aplication.Features.RegisterUser
{
    public sealed class RegisterUserCommand : ICommand<Guid>
    {
        public RegisterUserCommand(
            string name,
            string email,
            string phone,
            string companyId
            )
        {
            Name = name;
            Email = email;
            Phone = phone;
            CompanyId = companyId;
        }

        public string Name { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
        public string CompanyId { get; }
    }
}