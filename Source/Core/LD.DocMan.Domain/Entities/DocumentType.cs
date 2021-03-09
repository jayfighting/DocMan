using LD.DocMan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Domain.Entities
{
    public class DocumentType : AuditableEntity
    {
        public Guid DocumentTypeId { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public bool Active { get; set; }
        public string MainBranch { get; set; }
        public string SecBranch1 { get; set; }
        public string SecBranch2 { get; set; }
        public bool SendToAdr { get; set; }
        public bool TrustedAdrResult { get; set; }
        public decimal AdrTrustedMinimumThreshold { get; set; }
    }
}
