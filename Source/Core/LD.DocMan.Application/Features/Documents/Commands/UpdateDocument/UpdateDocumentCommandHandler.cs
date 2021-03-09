using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandHandler : IRequestHandler<UpdateDocumentCommand>
    {
        private IAsyncRepository<Document> _documentRepository;
        private IMapper _mapper;

        public UpdateDocumentCommandHandler(IAsyncRepository<Document> documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository;
            _mapper = mapper;   
        }

        public async Task<Unit> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDocumentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var document = _documentRepository.GetByIdAsync(request.DocumentId);
            await _mapper.Map(request, document);
            return Unit.Value;
        }
    }
}
