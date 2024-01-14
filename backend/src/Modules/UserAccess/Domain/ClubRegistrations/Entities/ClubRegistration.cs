using TotalCareManager.Shared.Domain;
using UserAccess.Domain.Clubs.Enumerations;
using UserAccess.Domain.Users.Entities;

namespace UserAccess.Domain.Clubs.Entities
{
    public sealed class ClubRegistration : Entity<ClubRegistrationId>
    {
        private readonly ClubType _clubType;
        private UserRegistrationId? _groupOwnerId;
        private string _groupName;

        public ClubRegistration(
            string groupName,
            ClubType clubType
            )
        {
            Id = new ClubRegistrationId(Guid.NewGuid());
            _groupName = groupName;
            _clubType = clubType;
        }

        public void ChangeClubName(string groupName)
        {
            if (_groupName == groupName)
                return;

            _groupName = groupName;
        }
    }
}