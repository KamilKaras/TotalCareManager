using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.ValueObjects
{
    public sealed record Phone : ValueObjectOf<string>
    {
        public Phone(string Value) : base(Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new PhoneEmptyException();
        }
    }

    public sealed class PhoneEmptyException : AppException
    {
        public PhoneEmptyException() : base("Email nie może być pusty")
        {
        }
    }
}