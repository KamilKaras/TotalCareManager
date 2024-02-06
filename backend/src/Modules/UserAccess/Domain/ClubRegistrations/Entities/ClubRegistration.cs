using TotalCareManager.Shared.Domain;
using UserAccess.Domain.ClubRegistrations.Events;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Domain.ClubRegistrations.Entities
{
    public sealed class ClubRegistration : Entity<ClubRegistrationId>
    {
        private string _clubType;
        private string _clubName;
        private string _clubNip;

        public ClubRegistration(
            string clubName,
            string clubNip,
            string clubType
            )
        {
            Id = new ClubRegistrationId(Guid.NewGuid());
            _clubName = clubName;
            _clubNip = clubNip;
            _clubType = clubType;

            AddDomainEvent(new ClubRegisterDomainEvent(Id, "", "", ""));
        }

        protected ClubRegistration()
        {
            // EF
        }

        public void ChangeClubOwner(UserRegistrationId ownerId)
        {
        }

        public void ChangeClubName(string clubName)
        {
            if (_clubName == clubName)
                return;

            _clubName = clubName;
        }

        public void ChangeClubType(string clubType)
        {
            if (_clubType == clubType)
                return;

            _clubType = clubType;
        }

        public void Confirm()
        {
        }
    }
}