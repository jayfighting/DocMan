using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Commands.CreateDocument
{
    public class AddDocumentCommandHandler : IRequestHandler<AddDocumentCommand, Guid>
    {
        private IAsyncRepository<Document> _documentRepository;
        private IMapper _mapper;

        public AddDocumentCommandHandler(IAsyncRepository<Document> documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(AddDocumentCommand request, CancellationToken cancellationToken)
        {
            var validator = new AddDocumentCommandValidator();
            var validationResults = await validator.ValidateAsync(request);
            if (validationResults.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResults);
            }
            var document = _mapper.Map<Document>(request);
            document = await _documentRepository.AddAsync(document);
            return document.Id;
                 
        }
    }
}
