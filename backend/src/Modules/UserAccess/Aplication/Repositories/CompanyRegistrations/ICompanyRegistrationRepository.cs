using TotalCareManager.Shared.DbAccess.Interfaces;
using UserAccess.Domain.Companies.Entities;

namespace UserAccess.Aplication.Repositories.CompanyRegistrations
{
    public interface ICompanyRegistrationRepository : IDomainRepository<CompanyRegistration, CompanyRegistrationId>
    {
    }
}