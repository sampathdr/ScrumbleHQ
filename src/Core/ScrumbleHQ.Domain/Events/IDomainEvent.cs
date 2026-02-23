using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumbleHQ.Domain.Events
{
    /// <summary>
    /// Base interface for domain events.
    /// Domain events represent something that happened in the domain that domain experts care about.
    /// </summary>
    public interface IDomainEvent
    {
        /// <summary>
        /// The date and time when the domain event occurred.
        /// </summary>
        DateTimeOffset OccurredOn { get; }
    }
}
