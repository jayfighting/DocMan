using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeDetail
{
    public class GetDocumentTypeDetailQuery : IRequest<DocumentTypeDetailVM>
    {
        public Guid Id { get; set; }
    }
}
