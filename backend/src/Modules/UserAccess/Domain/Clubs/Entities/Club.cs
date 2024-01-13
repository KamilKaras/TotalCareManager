using TotalCareManager.Shared.Domain;
using UserAccess.Domain.Clubs.Enumerations;
using UserAccess.Domain.Users.Entities;

namespace UserAccess.Domain.Clubs.Entities
{
    public sealed class Club : Entity<ClubId>
    {
        private readonly ClubType _clubType;
        private UserId? _groupOwnerId;
        private HashSet<UserId> _clubMembers;
        private string _groupName;

        public Club(
            string groupName,
            ClubType clubType
            )
        {
            Id = new ClubId(Guid.NewGuid());
            _groupName = groupName;
            _clubType = clubType;
        }

        public void ChangeClubName(string groupName)
        {
            if (_groupName == groupName)
                return;

            _groupName = groupName;
        }

        public void AddClubMember(UserId newMember)
        {
            _clubMembers.Add(newMember);
        }
    }
}