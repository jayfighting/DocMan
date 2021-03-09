using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeDetail
{
    public class DocumentTypeDetailVM
    {
        public Guid DocumentTypeId { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public bool Active { get; set; }
        public string MainBranch { get; set; }
        public string SecBranch1 { get; set; }
        public string SecBranch2 { get; set; }
        public bool SendToAdr { get; set; }
        public bool TrustedAdrReesult { get; set; }
        public decimal AdrTrustedMinimumThreshold { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedByName { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
