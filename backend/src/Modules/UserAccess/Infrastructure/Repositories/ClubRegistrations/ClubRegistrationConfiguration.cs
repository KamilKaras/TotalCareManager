using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Infrastructure.Repositories.ClubRegistrations
{
    internal sealed class ClubRegistrationConfiguration : IEntityTypeConfiguration<ClubRegistration>
    {
        public void Configure(EntityTypeBuilder<ClubRegistration> builder)
        {
            builder.Ignore(p => p.DomainEvents);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property<string>("_clubType")
               .HasColumnName("club_type");

            builder.Property<string>("_clubName")
               .HasColumnName("club_name");

            builder.Property<string>("_clubNip")
              .HasColumnName("club_nip");

            builder.ToTable("club_registration");
        }
    }
}