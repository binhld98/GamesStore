using MediatR;

namespace GameStore.Domain.Base
{
    public abstract record BaseDomainEvent : INotification;
}
