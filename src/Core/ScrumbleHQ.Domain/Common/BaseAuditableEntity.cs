using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumbleHQ.Domain.Common
{
    /// <summary>
    /// Base class for auditable entities that tracks creation and modification metadata.
    /// </summary>
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public Guid CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedAt { get; set; }
        public Guid? LastModifiedBy { get; set; }
    }
}
