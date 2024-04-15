using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace UserAccess.Aplication.Features.RegisterCompany
{
    public sealed class RegisterCompanyCommand : ICommand<Guid>
    {
        public RegisterCompanyCommand(
            int companyTypeId,
            string nip,
            string companyName,
            string userName,
            string userEmail,
            string userPhone

            )
        {
            CompanyTypeId = companyTypeId;
            Nip = nip;
            CompanyName = companyName;
            UserName = userName;
            UserEmail = userEmail;
            UserPhone = userPhone;
        }

        public int CompanyTypeId { get; }
        public string Nip { get; }
        public string CompanyName { get; }
        public string UserName { get; }
        public string UserEmail { get; }
        public string UserPhone { get; }
    }
}