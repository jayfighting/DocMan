using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Commands.CreateDocument
{
    public class AddDocumentCommand : IRequest<Guid>
    {
        public string LoanNumber { get; set; }
        public int BorrowerNumber { get; set; }
        public string Name { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid ParentId { get; set; }
        public bool FinalStamp { get; set; }
        public DateTime FinalStampDate { get; set; }
        public bool Trash { get; set; }
        public bool ForReview { get; set; }
        public string AdrStatus { get; set; }
        public DateTime AdrStatusDate { get; set; }
        public DateTime ViewedDate { get; set; }
        public bool SignatureRequired { get; set; }
        public DateTime SignatureDate { get; set; }
        public bool BorrowerSubmitted { get; set; }
        public bool Annotated { get; set; }
        public DateTime OneTimeConsentDate { get; set; }
        public DateTime DocumentRequestDate { get; set; }
        public DateTime DisclosureIssueDate { get; set; }
        public DateTime DisclosureReceiveDate { get; set; }
        public DateTime PaperRequested { get; set; }
        public DateTime PaperCompleted { get; set; }
        public DateTime Received { get; set; }
        public DateTime ConsentDate { get; set; }
        public DateTime Recalled { get; set; }
        public byte[] DocumentBinary { get; set; }
    }
}
