using TotalCareManager.Shared.Domain;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Domain.ClubRegistrations.Events
{
    public class ClubRegisterDomainEvent : DomainEvent
    {
        public ClubRegisterDomainEvent(
            ClubRegistrationId clubRegistrationId,
            string userName,
            string userEmail,
            string userPhone
            )
        {
            ClubRegistrationId = clubRegistrationId;
            UserName = userName;
            UserEmail = userEmail;
            UserPhone = userPhone;
        }

        public ClubRegistrationId ClubRegistrationId { get; }
        public string UserName { get; }
        public string UserEmail { get; }
        public string UserPhone { get; }
    }
}