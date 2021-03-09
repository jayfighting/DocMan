using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentDetail
{
    public class GetDocumentDetailQueryHandler : IRequestHandler<GetDocumentDetailQuery, DocumentDetailVM>
    {
        private readonly IAsyncRepository<DocumentDetailVM> _documentRepository;
        private readonly IMapper _mapper;

        public GetDocumentDetailQueryHandler(IAsyncRepository<DocumentDetailVM> documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;   
        }

        public async Task<DocumentDetailVM> Handle(GetDocumentDetailQuery request, CancellationToken cancellationToken)
        {
            var documentDetail = await _documentRepository.GetByIdAsync(request.Id);
            return _mapper.Map<DocumentDetailVM>(documentDetail);
        }
    }
}
