using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Common
{
    public abstract class AuditableEntity : Entity
    {
        public string CreatedByName { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedByName { get; set; }
        public Guid LastModifiedByUserId { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
