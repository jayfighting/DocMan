using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentBinary
{
    public class DocumentBinaryDto
    {
        public Guid DocumentId { get; set; }
        public string Name { get; set; }
        public string LoanNumber { get; set; }
        public string Path { get; set; }
        public DateTime Date { get; set; }

    }
}
