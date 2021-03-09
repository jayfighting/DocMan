using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using LD.DocMan.Application.Features.Documents.Commands.CreateDocument;

namespace LD.DocMan.Application.Features.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandValidator : AbstractValidator<UpdateDocumentCommand>
    {
        public UpdateDocumentCommandValidator()
        {
            RuleFor(doc => doc.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document Name can not be null or empty.");
        }
    }
}
