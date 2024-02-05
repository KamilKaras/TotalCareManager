using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace UserAccess.Aplication.Features.RegisterClub
{
    public sealed class RegisterClubCommand : ICommand<Guid>
    {
        public RegisterClubCommand(
            int clubTypeId,
            string userName,
            string userEmail,
            string userPhone

            )
        {
            ClubTypeId = clubTypeId;
            UserName = userName;
            UserEmail = userEmail;
            UserPhone = userPhone;
        }

        public int ClubTypeId { get; }
        public string UserName { get; init; }
        public string UserEmail { get; init; }
        public string UserPhone { get; init; }
    }
}