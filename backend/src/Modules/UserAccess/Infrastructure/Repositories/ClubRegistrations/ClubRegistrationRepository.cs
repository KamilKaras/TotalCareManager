using TotalCareManager.Shared.DbAccess.Implementations;
using UserAccess.Aplication.Repositories;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Infrastructure.Repositories.ClubRegistrations
{
    internal sealed class ClubRegistrationRepository : DomainRepository<ClubRegistration, ClubRegistrationId>, IClubRegistrationRepository
    {
        public ClubRegistrationRepository(UserAccessDbContext dbContext) : base(dbContext)
        {
        }
    }
}