using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace UserAccess.Aplication.Features.RegisterUser
{
    public sealed class RegisterUserCommand : ICommand<int>
    {
        public RegisterUserCommand(
            string name,
            string email,
            string phone

            )
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public string Name { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
    }
}