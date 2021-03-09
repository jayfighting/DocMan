using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Infrastructure.FileSystem;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Application.Features.Documents.Common.GetDocumentBinary;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Queries.GetDocumentBinary
{
    public class GetDocumentBinaryQueryHandler : IRequestHandler<GetDocumentBinaryQuery, DocumentFileVM>
    {
        private readonly IAsyncRepository<Document> _documentRepository;
        private readonly IMapper _mapper;
        private readonly IDocumentReader _documentReader;

        public GetDocumentBinaryQueryHandler(IAsyncRepository<Document> documentRepository, IMapper mapper, IDocumentReader documentReader)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
            _documentReader = documentReader;   
        }

        public async Task<DocumentFileVM> Handle(GetDocumentBinaryQuery request, CancellationToken cancellationToken)
        {
            var document =  _mapper.Map<DocumentBinaryDto>(await _documentRepository.GetByIdAsync((request.Id)));
            var documentData = _documentReader.ReadDocument(document);
            var documentBinary = new DocumentFileVM()
                {ContentType = "application/pdf", Data = documentData, FileName = document.Name };
            return documentBinary;
        }
    }
}
