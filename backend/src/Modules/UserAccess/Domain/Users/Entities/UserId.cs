using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Users.Entities
{
    public sealed record UserId : EntityId
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}