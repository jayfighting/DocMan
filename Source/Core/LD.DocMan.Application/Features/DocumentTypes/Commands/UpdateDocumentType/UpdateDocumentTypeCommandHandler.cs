using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using MediatR;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Application.Features.DocumentTypes.Commands.UpdateDocumentType
{
    public class UpdateDocumentTypeCommandHandler : IRequestHandler<UpdateDocumentTypeCommand>
    {
        private readonly IAsyncRepository<DocumentType> _documentTypeRepository;
        private readonly IMapper _mapper;

        public UpdateDocumentTypeCommandHandler(IAsyncRepository<DocumentType> documentTypeRepository, IMapper mapper)
        {
            _documentTypeRepository = documentTypeRepository;
            _mapper = mapper;   
        }

        public async Task<Unit> Handle(UpdateDocumentTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDocumentTypeCommandValidator();
            var validationResults = await validator.ValidateAsync(request);
            if (validationResults.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResults);
            }

            var documentTypeToUpdate = _documentTypeRepository.GetByIdAsync(request.DocumentTypeId);
            await _mapper.Map(request, documentTypeToUpdate);
            return Unit.Value;
        }
    }
}
