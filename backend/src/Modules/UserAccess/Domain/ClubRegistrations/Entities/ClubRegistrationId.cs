using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.ClubRegistrations.Entities
{
    public sealed record ClubRegistrationId : EntityId
    {
        public ClubRegistrationId(Guid value) : base(value)
        {
        }
    }
}