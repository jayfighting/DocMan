using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackList
{
    public class GetDocutechPushbackListRequest : IRequest<List<DocutechPushbackListVM>>
    {

    }
}
