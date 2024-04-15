using TotalCareManager.Shared.DbAccess.Interfaces;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Aplication.Repositories.UserRegistrations
{
    public interface IUserRegistrationRepository : IDomainRepository<UserRegistration, UserRegistrationId>

    {
    }
}