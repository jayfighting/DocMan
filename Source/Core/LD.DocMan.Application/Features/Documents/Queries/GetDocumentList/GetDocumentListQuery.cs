using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentList
{
    public  class GetDocumentListQuery : IRequest<List<DocumentListVM>>
    {

    }
}
