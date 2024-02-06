using TotalCareManager.Shared.DbAccess.Implementations;
using UserAccess.Aplication.Repositories;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Infrastructure.Repositories
{
    internal sealed class ClubRegistrationRepository : DomainRepository<ClubRegistration, ClubRegistrationId>, IClubRegistrationRepository
    {
        public ClubRegistrationRepository(UserAccessDbContext dbContext) : base(dbContext)
        {
        }
    }
}