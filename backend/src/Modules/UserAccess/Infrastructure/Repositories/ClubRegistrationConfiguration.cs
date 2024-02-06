using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserAccess.Domain.ClubRegistrations.Entities;

namespace UserAccess.Infrastructure.Repositories
{
    internal sealed class ClubRegistrationConfiguration : IEntityTypeConfiguration<ClubRegistration>
    {
        public void Configure(EntityTypeBuilder<ClubRegistration> builder)
        {
            builder.Ignore(p => p.DomainEvents);
            builder.Property("_clubType")
               .HasColumnName("club_type");

            builder.Property("_clubName")
               .HasColumnName("club_name");

            builder.Property("_clubNip")
              .HasColumnName("club_nip");

            builder.ToTable("club-registration");
        }
    }
}