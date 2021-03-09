using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedByName { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedByName { get; set; }
        public Guid LastModifiedByUserId { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
