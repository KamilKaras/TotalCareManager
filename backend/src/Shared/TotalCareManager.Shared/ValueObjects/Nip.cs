using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.ValueObjects
{
    public sealed record Nip : ValueObjectOf<string>
    {
        public Nip(string Value) : base(Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new NipEmptyException();
        }
    }

    public sealed class NipEmptyException : AppException
    {
        public NipEmptyException() : base("Nip nie może być pusty")
        {
        }
    }
}