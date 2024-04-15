using TotalCareManager.Shared.DbAccess.Implementations;
using UserAccess.Aplication.Repositories.CompanyRegistrations;
using UserAccess.Domain.Companies.Entities;

namespace UserAccess.Infrastructure.Repositories.CompanyRegistrations
{
    internal sealed class CompanyRegistrationRepository : DomainRepository<CompanyRegistration, CompanyRegistrationId>, ICompanyRegistrationRepository
    {
        public CompanyRegistrationRepository(UserAccessDbContext dbContext) : base(dbContext)
        {
        }
    }
}