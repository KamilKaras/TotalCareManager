using TotalCareManager.Shared.Messaging;

namespace UserAccess.Aplication.Features.RegisterGroup
{
    public sealed class RegisterGroupCommand : ICommand<int>
    {
        public RegisterGroupCommand(
            string groupName,
            string nipNumber,
            string companyName,
            string name,
            string email,
            string phone

            )
        {
            GroupName = groupName;
            Name = name;
            Email = email;
            Phone = phone;
            NipNumber = nipNumber;
            CompanyName = companyName;
        }

        public string GroupName { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
        public string NipNumber { get; init; }
        public string CompanyName { get; init; }
    }
}