using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeList
{
    public class GetDocumentTypeListQuery : IRequest<List<DocumentTypeListVM>>
    {

    }
}
