using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.ValueObjects;
using UserAccess.Domain.Companies.Entities;
using UserAccess.Domain.UserRegistrations.ValueObjects;

namespace UserAccess.Domain.UserRegistrations.Entities
{
    public sealed class UserRegistration : Entity<UserRegistrationId>
    {
        private readonly DateTimeOffset _registeredAt = DateTimeOffset.UtcNow;
        private readonly CompanyRegistrationId _companyId;
        private DateTimeOffset? _confirmedAt;
        private UserName _name;
        private Email _email;
        private Phone _phone;
        private string? _password = null;

        public UserRegistration(
            UserName name,
            Email email,
            Phone phone,
            CompanyRegistrationId companyId
            )
        {
            Id = new UserRegistrationId(Guid.NewGuid());
            _name = name;
            _email = email;
            _phone = phone;
            _companyId = companyId;
        }

        private UserRegistration()
        {
            //EF core
        }

        public void ChangeName(UserName name)
        {
            if (_name == name)
                return;

            _name = name;
        }

        public void ChangeEmail(Email email)
        {
            if (_email == email)
                return;

            _email = email;
        }

        public void ChangePhone(Phone phone)
        {
            if (_phone == phone)
                return;

            _phone = phone;
        }

        public void ChangePassword(string password)
        {
            if (_password == password)
                return;

            _password = password;
        }
    }
}