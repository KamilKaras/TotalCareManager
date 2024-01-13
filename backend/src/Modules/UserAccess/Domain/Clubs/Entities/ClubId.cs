using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Clubs.Entities
{
    public sealed record ClubId : EntityId
    {
        public ClubId(Guid value) : base(value)
        {
        }
    }
}