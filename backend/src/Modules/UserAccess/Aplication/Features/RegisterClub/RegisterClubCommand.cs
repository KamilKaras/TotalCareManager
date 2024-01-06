using TotalCareManager.Shared.Messaging;

namespace UserAccess.Aplication.Features.RegisterGroup
{
    public sealed class RegisterClubCommand : ICommand<Guid>
    {
        public RegisterClubCommand(
            string groupName,
            string nipNumber,
            string companyName,
            string userName,
            string userEmail,
            string userPhone

            )
        {
            GroupName = groupName;
            NipNumber = nipNumber;
            CompanyName = companyName;
            UserName = userName;
            UserEmail = userEmail;
            UserPhone = userPhone;
        }

        public string GroupName { get; init; }
        public string NipNumber { get; init; }
        public string CompanyName { get; init; }
        public string UserName { get; init; }
        public string UserEmail { get; init; }
        public string UserPhone { get; init; }
    }
}