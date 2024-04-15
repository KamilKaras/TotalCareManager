using TotalCareManager.Shared.DbAccess.Implementations;
using UserAccess.Aplication.Repositories.UserRegistrations;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Infrastructure.Repositories.UserRegistrations
{
    internal sealed class UserRegistrationRepository : DomainRepository<UserRegistration, UserRegistrationId>, IUserRegistrationRepository
    {
        public UserRegistrationRepository(UserAccessDbContext dbContext) : base(dbContext)
        {
        }
    }
}