using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.UserRegistrations.Entities
{
    public sealed class UserRegistration : Entity<UserRegistrationId>
    {
        private readonly DateTimeOffset _registeredAt = DateTimeOffset.UtcNow;
        private string _name;
        private string _email;
        private string _phone;
        private string _password;

        public UserRegistration(
            string name,
            string email,
            string phone,
            string password
            )
        {
            Id = new UserRegistrationId(Guid.NewGuid());
            _name = name;
            _email = email;
            _phone = phone;
            _password = password;
        }

        private UserRegistration()
        {
            //EF core
        }

        public void ChangeName(string name)
        {
            if (_name == name)
                return;

            _name = name;
        }

        public void ChangeEmail(string email)
        {
            if (_email == email)
                return;

            _email = email;
        }

        public void ChangePhone(string phone)
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