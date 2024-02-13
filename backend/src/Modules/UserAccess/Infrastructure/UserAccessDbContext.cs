using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.DomainEventDispatching.Interfaces;
using UserAccess.Domain.ClubRegistrations.Entities;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Infrastructure
{
    public class UserAccessDbContext : DbContext
    {
        private readonly IDomainEventsDispatcher _domainEventsDispatcher;

        public UserAccessDbContext(
            DbContextOptions<UserAccessDbContext> options,
            IDomainEventsDispatcher domainEventsDispatcher) : base(options)
        {
            _domainEventsDispatcher = domainEventsDispatcher;
        }

        public DbSet<ClubRegistration> ClubRegistrations { get; set; }
        public DbSet<UserRegistration> UserRegistrations { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);

            await _domainEventsDispatcher.DispatchEvents(this);

            return result;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        }
    }
}