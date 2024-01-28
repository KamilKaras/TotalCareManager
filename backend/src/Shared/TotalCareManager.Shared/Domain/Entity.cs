using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.Domain
{
    public abstract class Entity<T> : Entity
        where T : EntityId
    {
        protected Entity()
        {
        }

        public T Id { get; protected init; }
    }

    public abstract class Entity
    {
        private List<DomainEvent> _domainEvents = new();

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents;

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        protected void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
                throw new BusinessRuleValidationException(rule);
        }
    }
}