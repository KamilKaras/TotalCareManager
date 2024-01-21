using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.UserRegistrations.Entities
{
    public sealed record UserRegistrationId : EntityId
    {
        public UserRegistrationId(Guid value) : base(value)
        {
        }
    }
}