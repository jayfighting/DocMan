using System;
using System.Collections.Generic;
using System.Text;
using LD.DocMan.Application.Features.Documents.Common.GetDocumentBinary;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentBinary
{
    public class GetDocumentBinaryQuery : IRequest<DocumentFileVM>
    {
        public Guid Id { get; set; }
    }
}
