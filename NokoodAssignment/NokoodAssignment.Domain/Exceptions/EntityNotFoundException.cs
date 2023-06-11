using System;
using System.Collections.Generic;
using System.Text;

namespace NokoodAssignment.Domain.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public object EntityId { get; }
        public EntityNotFoundException(object? entityId) :base($"Couldn't find an entity with the provided id\nThe provided id : {entityId?.ToString()}")
        {
            EntityId = entityId;
        }
    }
}
