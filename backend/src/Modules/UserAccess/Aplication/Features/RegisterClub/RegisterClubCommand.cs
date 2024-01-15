using TotalCareManager.Shared.Messaging.Command;

namespace UserAccess.Aplication.Features.RegisterClub
{
    public sealed class RegisterClubCommand : ICommand<Guid>
    {
        public RegisterClubCommand(
            string clubName,
            int clubTypeId,
            string nipNumber,
            string companyName,
            string userName,
            string userEmail,
            string userPhone

            )
        {
            ClubName = clubName;
            ClubTypeId = clubTypeId;
            NipNumber = nipNumber;
            CompanyName = companyName;
            UserName = userName;
            UserEmail = userEmail;
            UserPhone = userPhone;
        }

        public string ClubName { get; init; }
        public int ClubTypeId { get; }
        public string NipNumber { get; init; }
        public string CompanyName { get; init; }
        public string UserName { get; init; }
        public string UserEmail { get; init; }
        public string UserPhone { get; init; }
    }
}