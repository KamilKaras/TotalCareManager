using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Groups.Entities
{
    public sealed class User : Entity<UserId>
    {
        private readonly string _name;
        private readonly string _email;
        private readonly string _phone;
        private readonly DateTimeOffset _createdAt = DateTimeOffset.UtcNow;
        private string _password;
        private HashSet<GroupId> _ownerOfGroupIds = new HashSet<GroupId>();
        private HashSet<GroupId> _memberOfGroupIds = new HashSet<GroupId>();

        public User(
            UserId id,
            string name,
            string email,
            string phone,
            string password
            )
        {
            Id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _password = password;
        }

        private User()
        {
            //EF core
        }

        public void BecomeGroupOwner(GroupId groupId)
        {
            _ownerOfGroupIds.Add(groupId);
        }
    }
}