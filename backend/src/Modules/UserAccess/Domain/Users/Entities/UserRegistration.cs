using TotalCareManager.Shared.Domain;
using UserAccess.Domain.Clubs.Entities;

namespace UserAccess.Domain.Users.Entities
{
    public sealed class UserRegistration : Entity<UserRegistrationId>
    {
        private readonly string _name;
        private readonly string _email;
        private readonly string _phone;
        private readonly DateTimeOffset _createdAt = DateTimeOffset.UtcNow;
        private string _password;
        private HashSet<ClubRegistrationId> _ownerOfGroupIds = new HashSet<ClubRegistrationId>();
        private HashSet<ClubRegistrationId> _memberOfGroupIds = new HashSet<ClubRegistrationId>();

        public UserRegistration(
            string name,
            string email,
            string phone,
            string password
            )
        {
            Id = new UserRegistrationId(Guid.NewGuid());
            _name = name;
            _email = email;
            _phone = phone;
            _password = password;
        }

        private UserRegistration()
        {
            //EF core
        }

        public void BecomeGroupOwner(ClubRegistrationId groupId)
        {
            _ownerOfGroupIds.Add(groupId);
        }
    }
}