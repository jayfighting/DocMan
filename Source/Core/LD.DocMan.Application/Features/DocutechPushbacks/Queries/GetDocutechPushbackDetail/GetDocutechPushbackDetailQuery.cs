using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackDetail
{
    public class GetDocutechPushbackDetailQuery : IRequest<DocutechPushbackDetailVM>
    {
        public Guid Id { get; set; }
    }
}
