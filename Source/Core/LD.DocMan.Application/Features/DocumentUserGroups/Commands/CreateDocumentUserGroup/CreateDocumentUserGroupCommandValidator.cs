using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace LD.DocMan.Application.Features.DocumentUserGroups.Commands.CreateDocumentUserGroup
{
    public class CreateDocumentUserGroupCommandValidator : AbstractValidator<CreateDocumentUserGroupCommand>
    {
        public CreateDocumentUserGroupCommandValidator()
        {
            RuleFor(ug => ug.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document User Group Name must not be null or empty.")
                .MaximumLength(100).WithMessage("Document User Group Name can not be longer than 100 characters.");
            RuleFor(ug => ug.Active)
                .Equal(false).WithMessage("Can not create an inactive Document User Group");
        }
    }
}
