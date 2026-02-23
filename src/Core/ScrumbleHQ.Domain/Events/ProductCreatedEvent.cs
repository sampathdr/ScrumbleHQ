using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumbleHQ.Domain.Events
{
    /// <summary>
    /// Domain event raised when a new product is created.
    /// </summary>
    public sealed class ProductCreatedEvent : IDomainEvent
    {
        public DateTimeOffset OccurredOn { get; }
        public Guid ProductId { get; }
        public string Name { get; }
        public Guid OrganizationId { get; }
        public Guid CreatedBy { get; }

        public ProductCreatedEvent(Guid productId, string name, Guid organizationId, Guid createdBy)
        {
            ProductId = productId;
            Name = name;
            OrganizationId = organizationId;
            CreatedBy = createdBy;
            OccurredOn = DateTimeOffset.UtcNow;
        }
    }
}
