using System;

namespace NokoodAssignment.Domain.Exceptions
{
    public class EntityAlreadyExistException : Exception
    {
        public object EntityId { get; set; }
        public EntityAlreadyExistException(object? entityId = default) : base($"Couldn't add/update this entity,Id : {entityId?.ToString()}\nBecause there's another entity that equals to it")
        {
            EntityId = entityId;
        }
    }
}
