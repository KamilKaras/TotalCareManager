using Microsoft.EntityFrameworkCore;
using UserAccess.Domain.ClubRegistrations.Entities;
using UserAccess.Domain.UserRegistrations.Entities;

namespace UserAccess.Infrastructure
{
    public class UserAccessDbContext : DbContext
    {
        public UserAccessDbContext(DbContextOptions<UserAccessDbContext> options) : base(options)
        {
        }

        public DbSet<ClubRegistration> ClubRegistrations { get; set; }
        public DbSet<UserRegistration> UserRegistrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                GetType()
                    .Assembly
            );
        }
    }
}