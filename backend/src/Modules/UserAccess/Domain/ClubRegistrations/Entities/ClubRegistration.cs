using TotalCareManager.Shared.Domain;
using UserAccess.Domain.ClubRegistrations.Enumerations;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Domain.ClubRegistrations.Entities
{
    public sealed class ClubRegistration : Entity<ClubRegistrationId>
    {
        private readonly DateTimeOffset _registeredAt = DateTimeOffset.UtcNow;
        private DateTimeOffset? _confirmedAt;
        private ClubType _clubType;
        private string _clubName;
        private string _clubNip;
        private UserRegistrationId? _clubOwner;

        public ClubRegistration(
            string clubName,
            string clubNip,
            ClubType clubType
            )
        {
            Id = new ClubRegistrationId(Guid.NewGuid());
            _clubName = clubName;
            _clubNip = clubNip;
            _clubType = clubType;
        }

        protected ClubRegistration()
        {
            // EF
        }

        public void ChangeClubOwner(UserRegistrationId ownerId)
        {
            if (_clubOwner == ownerId)
                return;

            _clubOwner = ownerId;
        }

        public void ChangeClubName(string clubName)
        {
            if (_clubName == clubName)
                return;

            _clubName = clubName;
        }

        public void ChangeClubType(ClubType clubType)
        {
            if (_clubType == clubType)
                return;

            _clubType = clubType;
        }

        public void Confirm()
        {
            _confirmedAt = DateTimeOffset.UtcNow;
        }
    }
}