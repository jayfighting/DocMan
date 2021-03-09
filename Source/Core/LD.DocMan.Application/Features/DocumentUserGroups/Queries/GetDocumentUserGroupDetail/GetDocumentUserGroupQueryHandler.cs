using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Queries.GetDocumentUserGroupDetail
{
    public class GetDocumentUserGroupQueryHandler : IRequestHandler<GetDocumentUserGroupDetailQuery, DocumentUserGroupDetailVM>
    {
        private readonly IAsyncRepository<DocumentUserGroupDetailVM> _documentUserGroupRepositry;
        private readonly IMapper _mapper;

        public GetDocumentUserGroupQueryHandler(IAsyncRepository<DocumentUserGroupDetailVM> documentUserGroupRepositry, IMapper mapper)
        {
            _documentUserGroupRepositry = documentUserGroupRepositry;
            _mapper = mapper;   
        }

        public async Task<DocumentUserGroupDetailVM> Handle(GetDocumentUserGroupDetailQuery request, CancellationToken cancellationToken)
        {
            var documentUserGroupDetail = await _documentUserGroupRepositry.GetByIdAsync(request.Id);
            var documentUserGroupDetailDto = _mapper.Map<DocumentUserGroupDetailVM>(documentUserGroupDetail);
            return documentUserGroupDetailDto;
        }
    }
}
