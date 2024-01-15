using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Users.Entities
{
    public sealed record UserRegistrationId : EntityId
    {
        public UserRegistrationId(Guid value) : base(value)
        {
        }
    }
}