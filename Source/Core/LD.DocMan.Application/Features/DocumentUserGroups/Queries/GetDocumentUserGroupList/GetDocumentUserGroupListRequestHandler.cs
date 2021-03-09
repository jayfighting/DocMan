using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Queries.GetDocumentUserGroupList
{
    public class GetDocumentUserGroupListRequestHandler :IRequestHandler<GetDocumentUserGroupListRequest, List<DocumentUserGroupListVM>>
    {
        private readonly IAsyncRepository<DocumentUserGroupListVM> _documentUserGroupRepository;
        private readonly IMapper _mapper;

        public GetDocumentUserGroupListRequestHandler(IAsyncRepository<DocumentUserGroupListVM> documentUserGroupRepository, IMapper mapper)
        {
            _documentUserGroupRepository = documentUserGroupRepository;
            _mapper = mapper;   
        }

        public async Task<List<DocumentUserGroupListVM>> Handle(GetDocumentUserGroupListRequest request, CancellationToken cancellationToken)
        {
            var allDocumentUserGroups = (await _documentUserGroupRepository.ListAllAsync()).OrderBy(ug => ug.Name);
            return _mapper.Map<List<DocumentUserGroupListVM>>(allDocumentUserGroups);
        }
    }
}
