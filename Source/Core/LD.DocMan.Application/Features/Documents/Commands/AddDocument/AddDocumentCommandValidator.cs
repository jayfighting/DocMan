using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FluentValidation;

namespace LD.DocMan.Application.Features.Documents.Commands.CreateDocument
{
    public class AddDocumentCommandValidator : AbstractValidator<AddDocumentCommand>
    {
        public AddDocumentCommandValidator()
        {
            RuleFor(doc => doc.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document Name can not be null or empty.");
            RuleFor((doc => doc.DocumentBinary))
                .NotNull()
                .NotEmpty().WithMessage("No document binary was supplied.");
        }
    }
}
