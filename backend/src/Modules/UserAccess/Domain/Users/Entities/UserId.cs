using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Groups.Entities
{
    public sealed record UserId : EntityId
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}