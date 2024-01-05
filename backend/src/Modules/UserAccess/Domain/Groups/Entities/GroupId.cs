using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Groups.Entities
{
    public sealed record GroupId : EntityId
    {
        public GroupId(Guid value) : base(value)
        {
        }
    }
}