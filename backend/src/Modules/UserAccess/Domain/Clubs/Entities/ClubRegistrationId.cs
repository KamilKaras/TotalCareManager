using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Clubs.Entities
{
    public sealed record ClubRegistrationId : EntityId
    {
        public ClubRegistrationId(Guid value) : base(value)
        {
        }
    }
}