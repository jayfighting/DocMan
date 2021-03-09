using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.UpdateDocumentCategory
{
    public class UpdateDocumentCategoryCommandHandler : IRequestHandler<UpdateDocumentCategoryCommand>
    {
        private readonly IAsyncRepository<DocumentCategory> _documentCategoryRepository;
        private readonly IMapper _mapper;

        public UpdateDocumentCategoryCommandHandler(IAsyncRepository<DocumentCategory> documentCategoryRepository, IMapper mapper)
        {
            _documentCategoryRepository = documentCategoryRepository;
            _mapper = mapper;   
        }

        public async Task<Unit> Handle(UpdateDocumentCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDocumentCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var documentCategoryToUpdate = _documentCategoryRepository.GetByIdAsync(request.CategoryId);
            await _mapper.Map(request, documentCategoryToUpdate);
            return Unit.Value;
        }
    }
}
