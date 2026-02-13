namespace GameStore.Domain.Base
{
    public abstract class BaseAuditedEntity : BaseEntity
    {
        public long CreatedBy { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset? LastModifiedAt { get; protected set; }

        public long? LastModifiedBy { get; protected set; }

        public DateTimeOffset? DeletedAt { get; protected set; }

        public long? DeletedBy { get; protected set; }
    }
}
