namespace NokoodAssignment.Domain.Entities
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; protected set; }
    }
}
