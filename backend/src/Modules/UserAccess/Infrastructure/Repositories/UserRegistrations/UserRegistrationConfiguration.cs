using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Domain.Companies.Entities;
using UserAccess.Domain.UserRegistrations.Entities;
using UserAccess.Domain.UserRegistrations.ValueObjects;

namespace UserAccess.Infrastructure.Repositories.UserRegistrations
{
    internal sealed class UserRegistrationConfiguration : IEntityTypeConfiguration<UserRegistration>
    {
        public void Configure(EntityTypeBuilder<UserRegistration> builder)
        {
            builder.Ignore(p => p.DomainEvents);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property<CompanyRegistrationId>("_companyId")
              .HasColumnName("company_id");

            builder.Property<UserName>("_name")
               .HasColumnName("name");

            builder.Property<Email>("_email")
               .HasColumnName("email");

            builder.Property<Phone>("_phone")
             .HasColumnName("phone");

            builder.Property<string>("_password")
              .HasColumnName("password");

            builder.Property<DateTimeOffset>("_registeredAt")
               .HasColumnName("registered_at");

            builder.Property<DateTimeOffset>("_confirmedAt")
              .HasColumnName("confirmed_at");

            builder.ToTable("user_registration");
        }
    }
}