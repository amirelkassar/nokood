using System;
using System.Collections.Generic;
using System.Text;

namespace NokoodAssignment.Domain.Entities
{
    public abstract class AuditedEntityBase<TKey> : EntityBase<TKey>
    {
        public DateTime CreationDate { get; protected set; }
        public Guid CreatorId { get; protected set; }
    }
}
