namespace ScrumbleHQ.Domain.Common
{
    /// <summary>
    /// Base interface for all entities in the domain.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets the unique identifier for the entity.
        /// </summary>
        Guid Id { get; }
    }
}
