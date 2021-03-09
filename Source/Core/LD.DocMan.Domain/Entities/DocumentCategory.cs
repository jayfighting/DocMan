using LD.DocMan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Entities
{
    public class DocumentCategory : AuditableEntity
    {
        public Guid DocumentCategoryId { get; set; }
        public string Name { get; set; }
        public Guid ParentId { get; set; }
    }
}
