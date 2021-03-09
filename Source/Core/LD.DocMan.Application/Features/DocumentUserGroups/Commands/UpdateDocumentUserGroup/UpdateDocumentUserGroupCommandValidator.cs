using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using LD.DocMan.Application.Features.DocumentUserGroups.Commands.CreateDocumentUserGroup;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.UpdateDocumentUserGroup
{
    public class UpdateDocumentUserGroupCommandValidator : AbstractValidator<UpdateDocumentUserGroupCommand>
    {
        public UpdateDocumentUserGroupCommandValidator()
        {
            RuleFor(ug => ug.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document User Group Name must not be null or empty.")
                .MaximumLength(100).WithMessage("Document User Group Name can not be longer than 100 characters.");
        }
    }
}
