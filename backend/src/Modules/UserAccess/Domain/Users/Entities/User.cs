using TotalCareManager.Shared.Domain;
using UserAccess.Domain.Clubs.Entities;

namespace UserAccess.Domain.Users.Entities
{
    public sealed class User : Entity<UserId>
    {
        private readonly string _name;
        private readonly string _email;
        private readonly string _phone;
        private readonly DateTimeOffset _createdAt = DateTimeOffset.UtcNow;
        private string _password;
        private HashSet<ClubId> _ownerOfGroupIds = new HashSet<ClubId>();
        private HashSet<ClubId> _memberOfGroupIds = new HashSet<ClubId>();

        public User(
            string name,
            string email,
            string phone,
            string password
            )
        {
            Id = new UserId(Guid.NewGuid());
            _name = name;
            _email = email;
            _phone = phone;
            _password = password;
        }

        private User()
        {
            //EF core
        }

        public void BecomeGroupOwner(ClubId groupId)
        {
            _ownerOfGroupIds.Add(groupId);
        }
    }
}