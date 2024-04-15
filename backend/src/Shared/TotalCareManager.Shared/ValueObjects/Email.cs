using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.ValueObjects
{
    public sealed record Email : ValueObjectOf<string>
    {
        public Email(string Value) : base(Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new EmailEmptyException();
        }
    }

    public sealed class EmailEmptyException : AppException
    {
        public EmailEmptyException() : base("Email nie może być pusty")
        {
        }
    }
}