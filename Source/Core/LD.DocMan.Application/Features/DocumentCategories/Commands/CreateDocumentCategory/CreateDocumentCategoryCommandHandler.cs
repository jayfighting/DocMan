using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory
{
    public class CreateDocumentCategoryCommandHandler :IRequestHandler<CreateDocumentCategoryCommand, Guid>
    {
        private readonly IDocumentCategoryRepository _documentCategoryRepository;
        private readonly IMapper _mapper;

        public CreateDocumentCategoryCommandHandler(IDocumentCategoryRepository documentCategoryRepository, IMapper mapper)
        {
            _documentCategoryRepository = documentCategoryRepository;
            _mapper = mapper;   
        }

        public async Task<Guid> Handle(CreateDocumentCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDocumentCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var documentCategory = _mapper.Map<DocumentCategory>(request);
            documentCategory = await _documentCategoryRepository.AddAsync(documentCategory);
            return documentCategory.DocumentCategoryId;
        }
    }
}
