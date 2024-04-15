using TotalCareManager.Shared.Domain.Implementations;
using UserAccess.Domain.Companies.Entities;

namespace UserAccess.Domain.Companies.Events
{
    public class CompanyRegisteredDomainEvent : DomainEvent
    {
        public CompanyRegisteredDomainEvent(
            CompanyRegistrationId businessRegistrationId

            )
        {
            BusinessRegistrationId = businessRegistrationId;
        }

        public CompanyRegistrationId BusinessRegistrationId { get; }
    }
}