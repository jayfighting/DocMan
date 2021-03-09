using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Application.Exceptions;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.UpdateDocumentUserGroup
{
    public class UpdateDocumentUserGroupCommandHandler : IRequestHandler<UpdateDocumentUserGroupCommand>
    {
        private readonly IAsyncRepository<DocumentUserGroup> _documentUserGroupRepository;
        private readonly IMapper _mapper;

        public UpdateDocumentUserGroupCommandHandler(IDocumentUserGroupRepository documentUserGroupRepository, IMapper mapper)
        {
            _documentUserGroupRepository = documentUserGroupRepository;
            _mapper = mapper;   
        }

        public async Task<Unit> Handle(UpdateDocumentUserGroupCommand request, CancellationToken cancellationToken)
        {
            var documentUserGroupToUpdate = await _documentUserGroupRepository.GetByIdAsync(request.UserGroupId);
            if (documentUserGroupToUpdate == null)
            {
                throw new NotFoundException(nameof(DocumentUserGroup), request.UserGroupId);
            }

            var validator = new UpdateDocumentUserGroupCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            
            _mapper.Map(request, documentUserGroupToUpdate, typeof(UpdateDocumentUserGroupCommand), typeof(DocumentUserGroup));
            await _documentUserGroupRepository.UpdateAsync(documentUserGroupToUpdate);
            return Unit.Value;
        }
    }
}
