using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Companies.Entities
{
    public sealed record CompanyRegistrationId : EntityId
    {
        public CompanyRegistrationId(Guid value) : base(value)
        {
        }
    }
}