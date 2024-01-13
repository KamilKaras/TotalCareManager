using TotalCareManager.Shared.Domain;
using UserAccess.Domain.Clubs.Enumerations;
using UserAccess.Domain.Users.Entities;

namespace UserAccess.Domain.Clubs.Entities
{
    public sealed class Club : Entity<ClubId>
    {
        private readonly UserId _groupOwnerId;
        private readonly ClubType _clubType;
        private string _groupName;

        public Club(
            string groupName,
            UserId groupOwnerId,
            ClubType clubType
            )
        {
            Id = new ClubId(Guid.NewGuid());
            _groupName = groupName;
            _groupOwnerId = groupOwnerId;
            _clubType = clubType;
        }

        public void ChangeGroupName(string groupName)
        {
            if (_groupName == groupName)
                return;

            _groupName = groupName;
        }
    }
}