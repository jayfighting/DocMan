using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeDetail
{
    public class GetDocumentTypeDetailQueryHandler : IRequestHandler<GetDocumentTypeDetailQuery, DocumentTypeDetailVM>
    {
        private readonly IAsyncRepository<DocumentTypeDetailVM> _documentTypeRepository;
        private readonly IMapper _mapper;

        public GetDocumentTypeDetailQueryHandler(IAsyncRepository<DocumentTypeDetailVM> documentTypeRepository, IMapper mapper)
        {
            _documentTypeRepository = documentTypeRepository;
            _mapper = mapper;   
        }

        public async Task<DocumentTypeDetailVM> Handle(GetDocumentTypeDetailQuery request, CancellationToken cancellationToken)
        {
            var documentTypeDetail = await _documentTypeRepository.GetByIdAsync(request.Id);
            var documentTypeDetailDto = _mapper.Map<DocumentTypeDetailVM>(documentTypeDetail);
            return documentTypeDetailDto;
        }
    }
}
