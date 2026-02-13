namespace GameStore.Domain.Base
{
    public abstract class BaseEntity
    {
        public long Id { get; protected set; }

        private readonly List<BaseDomainEvent> _domainEvents = new();

        public IReadOnlyCollection<BaseDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(BaseDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(BaseDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}
