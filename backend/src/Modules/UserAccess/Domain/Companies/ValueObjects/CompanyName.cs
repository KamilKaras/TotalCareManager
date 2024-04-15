using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace UserAccess.Domain.Companies.ValueObjects
{
    public sealed record CompanyName : ValueObjectOf<string>
    {
        public CompanyName(string Value) : base(Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                throw new NameEmptyException("działalności");
        }
    }
}