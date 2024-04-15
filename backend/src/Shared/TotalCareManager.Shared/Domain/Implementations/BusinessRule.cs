using TotalCareManager.Shared.Domain.Interfaces;

namespace TotalCareManager.Shared.Domain.Implementations
{
    public abstract class BusinessRule : IBusinessRule
    {
        public abstract string Message { get; }

        public string Code => GetType()
            .Name;

        public abstract bool IsBroken();
    }
}