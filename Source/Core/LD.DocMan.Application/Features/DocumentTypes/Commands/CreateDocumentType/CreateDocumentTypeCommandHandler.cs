using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentTypes.Commands.CreateDocumentType
{
    public class CreateDocumentTypeCommandHandler : IRequestHandler<CreateDocumentTypeCommand, Guid>
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IMapper _mapper;

        public CreateDocumentTypeCommandHandler(IDocumentTypeRepository documentTypeRepository, IMapper mapper)
        {
            _documentTypeRepository = documentTypeRepository;
            _mapper = mapper;   
        }

        public async Task<Guid> Handle(CreateDocumentTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDocumentTypeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            { throw new Exceptions.ValidationException(validationResult); }

            var documentType = _mapper.Map<Domain.Entities.DocumentType>(request);
            documentType = await _documentTypeRepository.AddAsync(documentType);
            return documentType.Id;
        }
    }
}
