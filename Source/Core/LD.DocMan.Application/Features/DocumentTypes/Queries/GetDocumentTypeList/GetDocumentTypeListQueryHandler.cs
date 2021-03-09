using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeList
{
    public class GetDocumentTypeListQueryHandler : IRequestHandler<GetDocumentTypeListQuery, List<DocumentTypeListVM>>
    {
        private readonly IAsyncRepository<DocumentTypeListVM> _documentTypeRepository;
        private readonly IMapper _mapper;

        public GetDocumentTypeListQueryHandler(IAsyncRepository<DocumentTypeListVM> documentTypeRepository, IMapper mapper)
        {
            _documentTypeRepository = documentTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<DocumentTypeListVM>> Handle(GetDocumentTypeListQuery request, CancellationToken cancellationToken)
        {
            var allDocumentTypes = (await _documentTypeRepository.ListAllAsync()).OrderBy(dt => dt.OrderId);
            return _mapper.Map<List<DocumentTypeListVM>>(allDocumentTypes);
        }
    }
}
