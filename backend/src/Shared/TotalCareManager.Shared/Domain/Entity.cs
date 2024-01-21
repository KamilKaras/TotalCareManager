using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.Domain
{
    public abstract class Entity<T> where T : EntityId
    {
        private List<DomainEvent> _domainEvents;

        protected internal Entity()
        {
        }

        public T Id { get; protected init; }

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents;

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        protected void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents ??= new List<DomainEvent>();

            _domainEvents.Add(domainEvent);
        }

        protected void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
                throw new BusinessRuleValidationException(rule);
        }
    }
}