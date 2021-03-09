using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Queries.GetDocumentUserGroupList
{
    public class GetDocumentUserGroupListRequest : IRequest<List<DocumentUserGroupListVM>>
    {

    }
}
