using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.Domain
{
    public abstract record EntityId : IEquatable<EntityId>
    {
        public Guid Value { get; }
        public EntityId(Guid value)
        {
            if (value == Guid.Empty)
                throw new InvalidEntityIdValueException();

            Value = value;
        }
    }
}