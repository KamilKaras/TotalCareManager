using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Groups.Entities
{
    public sealed class Group : Entity<GroupId>
    {
        private readonly string _groupName;
        private readonly string _groupOwner;
        private readonly string _groupOwnerEmail;
        private readonly string _groupOwnerPhone;

        public Group(
            GroupId groupId,
            string GroupName,
            string GroupOwner,
            string GroupOwnerEmail,
            string GroupOwnerPhone
            )
        {
            Id = groupId;
            _groupName = GroupName;
            _groupOwner = GroupOwner;
            _groupOwnerEmail = GroupOwnerEmail;
            _groupOwnerPhone = GroupOwnerPhone;
        }
    }
}