using TotalCareManager.Shared.DbAccess.Interfaces;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Aplication.Repositories
{
    public interface IClubRegistrationRepository : IDomainRepository<ClubRegistration, ClubRegistrationId>
    {
    }
}