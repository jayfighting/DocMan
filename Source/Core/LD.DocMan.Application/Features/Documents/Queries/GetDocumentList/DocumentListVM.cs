using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentList
{
    public class DocumentListVM
    {
        public Guid DocumentId { get; set; }
        public string LoanNumber { get; set; }
        public int BorrowerNumber { get; set; }
        public string Name { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool FinalStamp { get; set; }
        public DateTime FinalStampDate { get; set; }
        public bool Trash { get; set; }
        public bool ForReview { get; set; }
        public string AdrStatus { get; set; }
        public DateTime ViewedDate { get; set; }
        public bool SignatureRequired { get; set; }
        public DateTime SignatureDate { get; set; }
        public bool Annotated { get; set; }
        
    }
}
