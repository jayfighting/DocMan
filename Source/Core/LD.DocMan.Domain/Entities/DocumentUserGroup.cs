using LD.DocMan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Entities
{
    public class DocumentUserGroup : AuditableEntity
    {
        public Guid UserGroupId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
