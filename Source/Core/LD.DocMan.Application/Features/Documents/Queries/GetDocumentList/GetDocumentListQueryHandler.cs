using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentList
{
    public class GetDocumentListQueryHandler : IRequestHandler<GetDocumentListQuery, List<DocumentListVM>>
    {
        private readonly IAsyncRepository<Document> _documentRepository;
        private readonly IMapper _mapper;

        public GetDocumentListQueryHandler(IAsyncRepository<Document> documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;   
        }

        public async Task<List<DocumentListVM>> Handle(GetDocumentListQuery request, CancellationToken cancellationToken)
        {
            var allDocuments = (await _documentRepository.ListAllAsync()).OrderBy(d => d.Name);
            return _mapper.Map<List<DocumentListVM>>(allDocuments);
        }
    }
}
