using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentDetail
{
    public class GetDocumentDetailQuery : IRequest<DocumentDetailVM>
    {
        public Guid Id { get; set; }
    }
}
