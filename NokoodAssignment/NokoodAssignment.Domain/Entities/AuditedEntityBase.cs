using System;

namespace NokoodAssignment.Domain.Entities
{
    public abstract class AuditedEntityBase<TKey> : EntityBase<TKey>
    {
        public AuditedEntityBase()
        {
            CreationDate = DateTime.UtcNow;
        }
        public DateTime CreationDate { get; protected set; }
        public Guid CreatorId { get; protected set; }
    }
}
