using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LD.DocMan.Application.Contracts.Persistence;
using LD.DocMan.Domain.Entities;
using MediatR;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.CreateDocumentUserGroup
{
    public class CreateDocumentUserGroupCommandHandler : IRequestHandler<CreateDocumentUserGroupCommand, Guid>
    {
        private IDocumentUserGroupRepository _documentUserGroupRepository;
        private readonly IMapper _mapper;

        public CreateDocumentUserGroupCommandHandler(IDocumentUserGroupRepository documentUserGroupRepository, IMapper mapper)
        {
            _documentUserGroupRepository = documentUserGroupRepository;
            _mapper = mapper;   
        }

        public async Task<Guid> Handle(CreateDocumentUserGroupCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDocumentUserGroupCommandValidator();
            var validationResults = await validator.ValidateAsync(request);
            if (validationResults.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResults);
            }
            var documentUserGroup = _mapper.Map<DocumentUserGroup>(request);
            documentUserGroup = await _documentUserGroupRepository.AddAsync(documentUserGroup);
            return documentUserGroup.UserGroupId;
        }
    }
}
