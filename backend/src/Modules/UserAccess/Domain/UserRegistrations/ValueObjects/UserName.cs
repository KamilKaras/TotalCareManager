using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace UserAccess.Domain.UserRegistrations.ValueObjects
{
    public sealed record UserName : ValueObjectOf<string>
    {
        public UserName(string Value) : base(Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new NameEmptyException("użytkownika");
        }
    }
}