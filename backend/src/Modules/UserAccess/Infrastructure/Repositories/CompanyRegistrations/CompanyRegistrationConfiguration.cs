using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Domain.Companies.Entities;
using UserAccess.Domain.Companies.Enumerations;
using UserAccess.Domain.Companies.ValueObjects;

namespace UserAccess.Infrastructure.Repositories.CompanyRegistrations
{
    internal sealed class CompanyRegistrationConfiguration : IEntityTypeConfiguration<CompanyRegistration>
    {
        public void Configure(EntityTypeBuilder<CompanyRegistration> builder)
        {
            builder.Ignore(p => p.DomainEvents);

            builder.Property(p => p.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property<CompanyType>("_companyType")
               .HasColumnName("company_type");

            builder.Property<CompanyName>("_companyName")
               .HasColumnName("company_name");

            builder.Property<Nip>("_nip")
              .HasColumnName("nip");

            builder.ToTable("company_registration");
        }
    }
}