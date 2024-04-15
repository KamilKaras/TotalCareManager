using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Domain.Companies.Enumerations;
using UserAccess.Domain.Companies.Events;
using UserAccess.Domain.Companies.ValueObjects;

namespace UserAccess.Domain.Companies.Entities
{
    public sealed class CompanyRegistration : Entity<CompanyRegistrationId>
    {
        private CompanyName _companyName;
        private Nip _nip;
        private CompanyType _companyType;

        public CompanyRegistration(
            CompanyName companyName,
            Nip nip,
            CompanyType companyType
            )
        {
            Id = new CompanyRegistrationId(Guid.NewGuid());

            AddDomainEvent(new CompanyRegisteredDomainEvent(Id));
            _companyName = companyName;
            _nip = nip;
            _companyType = companyType;
        }

        protected CompanyRegistration()
        {
            // EF
        }

        public void ChangeName(CompanyName name)
        {
            if (_companyName == name)
                return;

            _companyName = name;
        }

        public void ChangeType(CompanyType companyType)
        {
            if (_companyType == companyType)
                return;

            _companyType = companyType;
        }

        public void Confirm()
        {
        }
    }
}