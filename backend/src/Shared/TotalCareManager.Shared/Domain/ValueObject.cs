using TotalCareManager.Shared.Domain.Implementations;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.Domain
{
    public abstract record ValueObject
    {
        protected static void CheckRule(BusinessRule rule)
        {
            if (rule.IsBroken())
                throw new BusinessRuleValidationException(rule);
        }
    }

    public abstract record ValueObjectOf<T>(T Value) : ValueObject
    {
        public static implicit operator T(ValueObjectOf<T> valueObject) => valueObject is null ? default : valueObject.Value;

        public override sealed string ToString() => Value?.ToString() ?? string.Empty;
    }
}