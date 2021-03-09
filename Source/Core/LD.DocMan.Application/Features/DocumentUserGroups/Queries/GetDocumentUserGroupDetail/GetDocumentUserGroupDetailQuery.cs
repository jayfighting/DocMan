using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Queries.GetDocumentUserGroupDetail
{
    public class GetDocumentUserGroupDetailQuery : IRequest<DocumentUserGroupDetailVM>
    {
        public Guid Id { get; set; }
    }
}
